﻿#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Graph
{
    public class RecordTypeAndField
    {
        public string RecordType { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;

        public override string ToString() => string.IsNullOrWhiteSpace(RecordType) ? Field : $"{RecordType}.{Field}";
    }
}
