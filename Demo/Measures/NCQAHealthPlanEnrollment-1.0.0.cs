using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
[CqlLibrary("NCQAHealthPlanEnrollment", "1.0.0")]
public class NCQAHealthPlanEnrollment_1_0_0
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public NCQAHealthPlanEnrollment_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        NCQACQLBase_1_0_0 = new NCQACQLBase_1_0_0(context);
        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQATerminology_1_0_0 = new NCQATerminology_1_0_0(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);

    }
    #region Dependencies

    public NCQACQLBase_1_0_0 NCQACQLBase_1_0_0 { get; }
    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQATerminology_1_0_0 NCQATerminology_1_0_0 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }

    #endregion

    [CqlDeclaration("CoverageIntervals")]
	public IEnumerable<CqlInterval<CqlDate>> CoverageIntervals(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		CqlInterval<CqlDate> a_(Coverage C)
		{
			var c_ = C?.Period;
			var d_ = NCQAFHIRBase_1_0_0.Normalize_Interval(c_);
			var e_ = context.Operators.Start(d_);
			var f_ = context.Operators.DateFrom(e_);
			var h_ = NCQAFHIRBase_1_0_0.Normalize_Interval(c_);
			var i_ = context.Operators.End(h_);
			var j_ = context.Operators.DateFrom(i_);
			var k_ = context.Operators.Interval(f_, j_, true, true);
			var l_ = context.Operators.Start(participationPeriod);
			var m_ = context.Operators.End(participationPeriod);
			var n_ = context.Operators.Interval(l_, m_, true, true);
			var o_ = context.Operators.IntervalIntersectsInterval<CqlDate>(k_, n_);

			return o_;
		};
		var b_ = context.Operators.SelectOrNull<Coverage, CqlInterval<CqlDate>>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Collapsed Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		var a_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(Intervals);

		return a_;
	}

    [CqlDeclaration("Collapsed Coverage Adjacent Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_(CqlInterval<CqlDate> _Coverage1) => 
			Intervals;
		Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK b_(CqlInterval<CqlDate> _Coverage1, CqlInterval<CqlDate> _Coverage2)
		{
			var h_ = new Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK
			{
				Coverage1 = _Coverage1,
				Coverage2 = _Coverage2,
			};

			return h_;
		};
		var c_ = context.Operators.SelectManyResultsOrNull<CqlInterval<CqlDate>, CqlInterval<CqlDate>, Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(Intervals, a_, b_);
		bool? d_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var i_ = context.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1);
			var j_ = context.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2);
			var k_ = context.Operators.Quantity(1m, "day");
			var l_ = context.Operators.Subtract(j_, k_);
			var o_ = context.Operators.Add(j_, k_);
			var p_ = context.Operators.Interval(l_, o_, true, true);
			var q_ = context.Operators.ElementInInterval<CqlDate>(i_, p_, null);
			var s_ = context.Operators.Not((bool?)(j_ is null));
			var t_ = context.Operators.And(q_, s_);

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK>(c_, d_);
		CqlInterval<CqlDate> f_(Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK tuple_gdeceaqjofqdgfgxnexuvihlk)
		{
			var u_ = context.Operators.Start(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage1);
			var v_ = context.Operators.End(tuple_gdeceaqjofqdgfgxnexuvihlk.Coverage2);
			var w_ = context.Operators.Interval(u_, v_, true, true);

			return w_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_GDEcEaQjOFQDGfGXNEXUVihLK, CqlInterval<CqlDate>>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Collapsed Final Coverage Intervals")]
	public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
	{
		var a_ = this.Collapsed_Coverage_Intervals(collapsedI);
		var b_ = this.Collapsed_Coverage_Adjacent_Intervals(adjacentI);
		var c_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(a_, b_);
		var d_ = NCQACQLBase_1_0_0.Collapse_Date_Interval_Workaround(c_);

		return d_;
	}

    [CqlDeclaration("All Coverage Info")]
	public IEnumerable<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC> All_Coverage_Info(IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
	{
		Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC a_(Coverage C)
		{
			var c_ = this.CoverageIntervals(Coverage, participationPeriod);
			var e_ = this.Collapsed_Coverage_Intervals(c_);
			var g_ = this.Collapsed_Coverage_Intervals(c_);
			var h_ = this.Collapsed_Coverage_Adjacent_Intervals(g_);
			var j_ = this.Collapsed_Coverage_Intervals(c_);
			var l_ = this.Collapsed_Coverage_Intervals(c_);
			var m_ = this.Collapsed_Coverage_Adjacent_Intervals(l_);
			var n_ = this.Collapsed_Final_Coverage_Intervals(j_, m_);
			var o_ = new Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC
			{
				IntervalInfo = c_,
				Collapsed = e_,
				Adjacent = h_,
				CollapsedFinal = n_,
			};

			return o_;
		};
		var b_ = context.Operators.SelectOrNull<Coverage, Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(Coverage, a_);

		return b_;
	}

    [CqlDeclaration("Health Plan Coverage Resources")]
	public IEnumerable<Coverage> Health_Plan_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var e_ = C?.Type;
			var f_ = e_?.Coding;
			bool? g_(Coding cTypeCoding)
			{
				var j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var k_ = NCQATerminology_1_0_0.managed_care_policy();
				var l_ = context.Operators.Equivalent(j_, k_);
				var n_ = NCQATerminology_1_0_0.retiree_health_program();
				var o_ = context.Operators.Equivalent(j_, n_);
				var p_ = context.Operators.Or(l_, o_);
				var r_ = NCQATerminology_1_0_0.subsidized_health_program();
				var s_ = context.Operators.Equivalent(j_, r_);
				var t_ = context.Operators.Or(p_, s_);

				return t_;
			};
			var h_ = context.Operators.WhereOrNull<Coding>((f_ as IEnumerable<Coding>), g_);
			var i_ = context.Operators.ExistsInList<Coding>(h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<Coverage>(Coverage, a_);
		bool? c_(Coverage HPCoverageResource)
		{
			var u_ = context.Operators.Not((bool?)(HPCoverageResource is null));

			return u_;
		};
		var d_ = context.Operators.WhereOrNull<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Anchor Date Criteria")]
	public bool? Anchor_Date_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
	{
		bool? a_()
		{
			if ((context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null) ?? false))
			{
				var b_ = this.All_Coverage_Info(Coverage, participationPeriod);
				bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
				{
					var k_ = @this?.CollapsedFinal;
					var l_ = context.Operators.Not((bool?)(k_ is null));

					return l_;
				};
				var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
				IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
				{
					var m_ = @this?.CollapsedFinal;

					return m_;
				};
				var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
				var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
				bool? h_(CqlInterval<CqlDate> FinalInterval)
				{
					var n_ = context.Operators.ElementInInterval<CqlDate>(AnchorDate, FinalInterval, null);

					return n_;
				};
				var i_ = context.Operators.WhereOrNull<CqlInterval<CqlDate>>(g_, h_);
				var j_ = context.Operators.ExistsInList<CqlInterval<CqlDate>>(i_);

				return j_;
			}
			else if ((context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(AnchorDate, participationPeriod, null)) ?? false))
			{
				bool? o_(Coverage @this)
				{
					var v_ = @this?.Period;
					var w_ = context.Operators.Not((bool?)(v_ is null));

					return w_;
				};
				var p_ = context.Operators.WhereOrNull<Coverage>(Coverage, o_);
				Period q_(Coverage @this)
				{
					var x_ = @this?.Period;

					return x_;
				};
				var r_ = context.Operators.SelectOrNull<Coverage, Period>(p_, q_);
				bool? s_(Period Cperiod)
				{
					var y_ = NCQAFHIRBase_1_0_0.Normalize_Interval(Cperiod);
					var z_ = context.Operators.Start(y_);
					var aa_ = context.Operators.DateFrom(z_);
					var ac_ = context.Operators.End(y_);
					var ad_ = context.Operators.DateFrom(ac_);
					var ae_ = context.Operators.Interval(aa_, ad_, true, true);
					var af_ = context.Operators.ElementInInterval<CqlDate>(AnchorDate, ae_, null);

					return af_;
				};
				var t_ = context.Operators.WhereOrNull<Period>(r_, s_);
				var u_ = context.Operators.ExistsInList<Period>(t_);

				return u_;
			}
			else if ((AnchorDate is null))
			{
				return (bool?)true;
			}
			else
			{
				return (bool?)false;
			};
		};

		return a_();
	}

    [CqlDeclaration("Health Plan Enrollment Criteria")]
	public bool? Health_Plan_Enrollment_Criteria(IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Health_Plan_Coverage_Resources(Coverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var m_ = @this?.CollapsedFinal;
			var n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var o_ = @this?.CollapsedFinal;

			return o_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var p_ = GapsInEnrollment?.Interval_Count;
			var q_ = context.Operators.LessOrEqual(p_, (int?)1);
			var r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			var t_ = context.Operators.And(q_, s_);
			var u_ = this.Anchor_Date_Criteria(Coverage, AnchorDate, participationPeriod);
			var v_ = context.Operators.And(t_, u_);

			return v_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		var l_ = context.Operators.SingleOrNull<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Pharmacy Benefit Coverage Resources")]
	public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var e_ = C?.Type;
			var f_ = e_?.Coding;
			bool? g_(Coding cTypeCoding)
			{
				var j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var k_ = NCQATerminology_1_0_0.drug_policy();
				var l_ = context.Operators.Equivalent(j_, k_);

				return l_;
			};
			var h_ = context.Operators.WhereOrNull<Coding>((f_ as IEnumerable<Coding>), g_);
			var i_ = context.Operators.ExistsInList<Coding>(h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<Coverage>(Coverage, a_);
		bool? c_(Coverage pharmacyCoverageResource)
		{
			var m_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Pharmacy Benefit Enrollment Criteria")]
	public bool? Pharmacy_Benefit_Enrollment_Criteria(IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Pharmacy_Benefit_Coverage_Resources(PharmCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var m_ = @this?.CollapsedFinal;
			var n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var o_ = @this?.CollapsedFinal;

			return o_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var p_ = GapsInEnrollment?.Interval_Count;
			var q_ = context.Operators.LessOrEqual(p_, (int?)1);
			var r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			var t_ = context.Operators.And(q_, s_);
			var u_ = this.Anchor_Date_Criteria(PharmCoverage, AnchorDate, participationPeriod);
			var v_ = context.Operators.And(t_, u_);

			return v_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		var l_ = context.Operators.SingleOrNull<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Mental Health Benefit Coverage Resources")]
	public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(IEnumerable<Coverage> Coverage)
	{
		bool? a_(Coverage C)
		{
			var e_ = C?.Type;
			var f_ = e_?.Coding;
			bool? g_(Coding cTypeCoding)
			{
				var j_ = FHIRHelpers_4_0_001.ToCode(cTypeCoding);
				var k_ = NCQATerminology_1_0_0.mental_health_policy();
				var l_ = context.Operators.Equivalent(j_, k_);

				return l_;
			};
			var h_ = context.Operators.WhereOrNull<Coding>((f_ as IEnumerable<Coding>), g_);
			var i_ = context.Operators.ExistsInList<Coding>(h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<Coverage>(Coverage, a_);
		bool? c_(Coverage mentalHealthCoverageResource)
		{
			var m_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

			return m_;
		};
		var d_ = context.Operators.WhereOrNull<Coverage>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Mental Health Benefit Enrollment Criteria")]
	public bool? Mental_Health_Benefit_Enrollment_Criteria(IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
	{
		var a_ = this.Mental_Health_Benefit_Coverage_Resources(MHCoverage);
		var b_ = this.All_Coverage_Info(a_, participationPeriod);
		bool? c_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var m_ = @this?.CollapsedFinal;
			var n_ = context.Operators.Not((bool?)(m_ is null));

			return n_;
		};
		var d_ = context.Operators.WhereOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC>(b_, c_);
		IEnumerable<CqlInterval<CqlDate>> e_(Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC @this)
		{
			var o_ = @this?.CollapsedFinal;

			return o_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EEdUbUaNBDSUUQFEZDJDbZRcC, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
		var g_ = context.Operators.FlattenList<CqlInterval<CqlDate>>(f_);
		var h_ = NCQACQLBase_1_0_0.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(participationPeriod, g_);
		var i_ = new Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD[]
		{
			h_,
		};
		bool? j_(Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD GapsInEnrollment)
		{
			var p_ = GapsInEnrollment?.Interval_Count;
			var q_ = context.Operators.LessOrEqual(p_, (int?)1);
			var r_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
			var s_ = context.Operators.LessOrEqual(r_, AllowedGapDays);
			var t_ = context.Operators.And(q_, s_);
			var u_ = this.Anchor_Date_Criteria(MHCoverage, AnchorDate, participationPeriod);
			var v_ = context.Operators.And(t_, u_);

			return v_;
		};
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DMLKdYCdQIGCNZIeiaWHeZXaD, bool?>(i_, j_);
		var l_ = context.Operators.SingleOrNull<bool?>(k_);

		return l_;
	}

}