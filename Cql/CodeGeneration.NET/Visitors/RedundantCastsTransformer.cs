﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class RedundantCastsTransformer : ExpressionVisitor
    {
        private readonly bool special;

        public RedundantCastsTransformer(bool special = false)
        {
            this.special = special;
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            var condition = Visit(node.Test);

            // if(true,A,B) => A /  if(false,A,B) => B
            return condition switch
            {
                ConstantExpression { Value: true } => Visit(node.IfTrue),
                ConstantExpression { Value: false } => Visit(node.IfFalse),
                _ => node.Update(condition, Visit(node.IfTrue), Visit(node.IfFalse))
            };
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            // ((x as Y) as Y) => (x as Y)
            if (node.NodeType == ExpressionType.TypeAs &&
                node.Expression is TypeBinaryExpression { NodeType: ExpressionType.TypeAs } nested &&
                node.TypeOperand == nested.TypeOperand)
            {
                return base.Visit(node.Expression);
            }
            else
                return base.VisitTypeBinary(node);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            // ((T?)a::T) ?? b::T => a
            if (node is
                {
                    NodeType: ExpressionType.Coalesce,
                    Left: UnaryExpression { NodeType: ExpressionType.Convert } conversion
                } && Nullable.GetUnderlyingType(conversion.Operand.Type) is null
                 && Nullable.GetUnderlyingType(conversion.Type) == conversion.Operand.Type
                )
            {
                return Visit(conversion.Operand);
            }

            return base.VisitBinary(node);
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node is { NodeType: ExpressionType.Convert } conversion)
            {
                var reducedOperand = Visit(conversion.Operand);

                // Deal with nested conversions, so node is a conversion and nested is a conversion
                if (reducedOperand is UnaryExpression { NodeType: ExpressionType.Convert } nestedConversion)
                {
                    // (Z)(Z)x => (Z)x
                    if (nestedConversion.Type == conversion.Type)
                    {
                        return nestedConversion;
                    }

                    // (T)(T?)x::T => x
                    else if (Nullable.GetUnderlyingType(nestedConversion.Type) == conversion.Type)
                    {
                        var reducedOperandOfNestedConversion = Visit(nestedConversion.Operand);
                        if (reducedOperandOfNestedConversion.Type == node.Type)
                            return reducedOperandOfNestedConversion;
                        else
                            return conversion.Update(nestedConversion.Update(reducedOperandOfNestedConversion));
                    }
                }

                // Check whether we can remove the cast otherwise
                var removeCast = true;
                if (conversion.Type.IsAssignableFrom(conversion.Operand.Type) == false)
                    removeCast = false;

                if (conversion.Method != null)
                    removeCast = false;
                if (conversion.Type.IsGenericType
                    && conversion.Type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    if (conversion.Operand.NodeType == ExpressionType.Constant
                        || conversion.Operand.NodeType == ExpressionType.Default)
                        removeCast = false;
                    if (conversion.Operand is BinaryExpression be && be.NodeType == ExpressionType.Equal
                        && (be.Right.NodeType == ExpressionType.Constant
                        || be.Right.NodeType == ExpressionType.Default))
                    {
                        removeCast = false;
                    }
                }
                else
                {
                    if (conversion.Type != typeof(object))
                    {
                        removeCast = false;
                    }
                    else
                    {
                        if (reducedOperand.Type.IsValueType)
                            removeCast = false;
                    }
                }

                if (removeCast)
                {
                    return reducedOperand;
                }

                return conversion.Update(reducedOperand);
            }

            return base.VisitUnary(node);
        }
    }
}
