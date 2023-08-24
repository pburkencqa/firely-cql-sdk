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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("BreastCancerScreeningsFHIR", "0.0.009")]
public class BreastCancerScreeningsFHIR_0_0_009
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bilateral_Mastectomy;
    internal Lazy<CqlValueSet> __History_of_bilateral_mastectomy;
    internal Lazy<CqlValueSet> __Left;
    internal Lazy<CqlValueSet> __Mammography;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Right;
    internal Lazy<CqlValueSet> __Status_Post_Left_Mastectomy;
    internal Lazy<CqlValueSet> __Status_Post_Right_Mastectomy;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Left;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy_Right;
    internal Lazy<CqlValueSet> __Unilateral_Mastectomy__Unspecified_Laterality;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Telehealth_Services;
    internal Lazy<int?> __Age_at_start_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Right_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Right_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Left_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Left_Mastectomy_Procedure;
    internal Lazy<IEnumerable<Condition>> __Bilateral_Mastectomy_Diagnosis;
    internal Lazy<IEnumerable<Procedure>> __Bilateral_Mastectomy_Procedure;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<bool?> __Observation_with_status;
    internal Lazy<bool?> __Diagnostic_Report_with_status;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Final_Numerator_Population;
    internal Lazy<bool?> __Observation_without_appropriate_status;
    internal Lazy<bool?> __Diagnostic_Report_without_appropriate_status;

    #endregion
    public BreastCancerScreeningsFHIR_0_0_009(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        AdultOutpatientEncountersFHIR4_2_2_000 = new AdultOutpatientEncountersFHIR4_2_2_000(context);
        AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 = new AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000(context);
        PalliativeCareFHIR_0_6_000 = new PalliativeCareFHIR_0_6_000(context);
        CumulativeMedicationDurationFHIR4_1_0_000 = new CumulativeMedicationDurationFHIR4_1_0_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);

        __Bilateral_Mastectomy = new Lazy<CqlValueSet>(this.Bilateral_Mastectomy_Value);
        __History_of_bilateral_mastectomy = new Lazy<CqlValueSet>(this.History_of_bilateral_mastectomy_Value);
        __Left = new Lazy<CqlValueSet>(this.Left_Value);
        __Mammography = new Lazy<CqlValueSet>(this.Mammography_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Right = new Lazy<CqlValueSet>(this.Right_Value);
        __Status_Post_Left_Mastectomy = new Lazy<CqlValueSet>(this.Status_Post_Left_Mastectomy_Value);
        __Status_Post_Right_Mastectomy = new Lazy<CqlValueSet>(this.Status_Post_Right_Mastectomy_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Unilateral_Mastectomy_Left = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Left_Value);
        __Unilateral_Mastectomy_Right = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy_Right_Value);
        __Unilateral_Mastectomy__Unspecified_Laterality = new Lazy<CqlValueSet>(this.Unilateral_Mastectomy__Unspecified_Laterality_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Telehealth_Services = new Lazy<IEnumerable<Encounter>>(this.Telehealth_Services_Value);
        __Age_at_start_of_Measurement_Period = new Lazy<int?>(this.Age_at_start_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Right_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Right_Mastectomy_Diagnosis_Value);
        __Right_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Right_Mastectomy_Procedure_Value);
        __Left_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Left_Mastectomy_Diagnosis_Value);
        __Left_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Left_Mastectomy_Procedure_Value);
        __Bilateral_Mastectomy_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Bilateral_Mastectomy_Diagnosis_Value);
        __Bilateral_Mastectomy_Procedure = new Lazy<IEnumerable<Procedure>>(this.Bilateral_Mastectomy_Procedure_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Observation_with_status = new Lazy<bool?>(this.Observation_with_status_Value);
        __Diagnostic_Report_with_status = new Lazy<bool?>(this.Diagnostic_Report_with_status_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Final_Numerator_Population = new Lazy<bool?>(this.Final_Numerator_Population_Value);
        __Observation_without_appropriate_status = new Lazy<bool?>(this.Observation_without_appropriate_status_Value);
        __Diagnostic_Report_without_appropriate_status = new Lazy<bool?>(this.Diagnostic_Report_without_appropriate_status_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public AdultOutpatientEncountersFHIR4_2_2_000 AdultOutpatientEncountersFHIR4_2_2_000 { get; }
    public AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 { get; }
    public PalliativeCareFHIR_0_6_000 PalliativeCareFHIR_0_6_000 { get; }
    public CumulativeMedicationDurationFHIR4_1_0_000 CumulativeMedicationDurationFHIR4_1_0_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }

    #endregion

    private CqlValueSet Bilateral_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005")]
    public CqlValueSet Bilateral_Mastectomy() => __Bilateral_Mastectomy.Value;

    private CqlValueSet History_of_bilateral_mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlDeclaration("History of bilateral mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068")]
    public CqlValueSet History_of_bilateral_mastectomy() => __History_of_bilateral_mastectomy.Value;

    private CqlValueSet Left_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);

    [CqlDeclaration("Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036")]
    public CqlValueSet Left() => __Left.Value;

    private CqlValueSet Mammography_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);

    [CqlDeclaration("Mammography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047")]
    public CqlValueSet Mammography() => __Mammography.Value;

    private CqlValueSet Online_Assessments_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments() => __Online_Assessments.Value;

    private CqlValueSet Right_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);

    [CqlDeclaration("Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035")]
    public CqlValueSet Right() => __Right.Value;

    private CqlValueSet Status_Post_Left_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlDeclaration("Status Post Left Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069")]
    public CqlValueSet Status_Post_Left_Mastectomy() => __Status_Post_Left_Mastectomy.Value;

    private CqlValueSet Status_Post_Right_Mastectomy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlDeclaration("Status Post Right Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070")]
    public CqlValueSet Status_Post_Right_Mastectomy() => __Status_Post_Right_Mastectomy.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlValueSet Unilateral_Mastectomy_Left_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133")]
    public CqlValueSet Unilateral_Mastectomy_Left() => __Unilateral_Mastectomy_Left.Value;

    private CqlValueSet Unilateral_Mastectomy_Right_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134")]
    public CqlValueSet Unilateral_Mastectomy_Right() => __Unilateral_Mastectomy_Right.Value;

    private CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    [CqlDeclaration("Unilateral Mastectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071")]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality() => __Unilateral_Mastectomy__Unspecified_Laterality.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2021, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2022, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", f_);

		return (CqlInterval<CqlDateTime>)g_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var i_ = this.Online_Assessments();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = this.Telephone_Visits();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, null);
		var m_ = context?.Operators.ListUnion<Encounter>(j_, l_);
		var n_ = (Encounter TelehealthEncounter) =>
		{
			var a_ = (TelehealthEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = this.Measurement_Period();
			var f_ = (TelehealthEncounter?.Period as object);
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
			var h_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, null);

			return context?.Operators.And(d_, h_);
		};

		return context?.Operators.WhereOrNull<Encounter>(m_, n_);
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private int? Age_at_start_of_Measurement_Period_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);

		return context?.Operators.CalculateAgeAt(b_, e_, "year");
	}

    [CqlDeclaration("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period() => __Age_at_start_of_Measurement_Period.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = (this.Patient()?.BirthDateElement?.Value as object);
		var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
		var c_ = this.Measurement_Period();
		var d_ = context?.Operators.Start(c_);
		var e_ = context?.Operators.DateFrom(d_);
		var f_ = context?.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context?.Operators.Interval((int?)51, (int?)74, true, false);
		var h_ = context?.Operators.ElementInInterval<int?>(f_, g_, null);
		var i_ = (this.Patient()?.GenderElement as object);
		var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
		var k_ = (j_ as object);
		var l_ = context?.Operators.Equal(k_, ("female" as object));
		var m_ = context?.Operators.And(h_, l_);
		var n_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var o_ = this.Telehealth_Services();
		var p_ = context?.Operators.ListUnion<Encounter>(n_, o_);
		var q_ = context?.Operators.ExistsInList<Encounter>(p_);

		return context?.Operators.And(m_, q_);
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Value()
	{
		var i_ = this.Status_Post_Right_Mastectomy();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Condition>(i_, null);
		var k_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Condition>(k_, null);
		var m_ = (Condition UnilateralMastectomyDiagnosis) =>
		{
			var a_ = (UnilateralMastectomyDiagnosis?.BodySite as IEnumerable<CodeableConcept>);
			var b_ = (CodeableConcept X) => FHIRHelpers_4_0_001.ToConcept(X);
			var c_ = context?.Operators.SelectOrNull<CodeableConcept, CqlConcept>(a_, b_);
			var d_ = this.Right();

			return context?.Operators.ConceptsInValueSet(c_, d_);
		};
		var n_ = context?.Operators.WhereOrNull<Condition>(l_, m_);
		var o_ = context?.Operators.ListUnion<Condition>(j_, n_);
		var p_ = (Condition RightMastectomy) =>
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(RightMastectomy);
			var f_ = context?.Operators.Start(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.End(g_);

			return context?.Operators.SameOrBefore(f_, h_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(o_, p_);
	}

    [CqlDeclaration("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis() => __Right_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Value()
	{
		var k_ = this.Unilateral_Mastectomy_Right();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(k_, null);
		var m_ = (Procedure UnilateralMastectomyRightPerformed) =>
		{
			var a_ = (UnilateralMastectomyRightPerformed?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (UnilateralMastectomyRightPerformed?.Performed as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.SameOrBefore(g_, i_, null);

			return context?.Operators.And(d_, j_);
		};

		return context?.Operators.WhereOrNull<Procedure>(l_, m_);
	}

    [CqlDeclaration("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure() => __Right_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Value()
	{
		var i_ = this.Status_Post_Left_Mastectomy();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Condition>(i_, null);
		var k_ = this.Unilateral_Mastectomy__Unspecified_Laterality();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Condition>(k_, null);
		var m_ = (Condition UnilateralMastectomyDiagnosis) =>
		{
			var a_ = (UnilateralMastectomyDiagnosis?.BodySite as IEnumerable<CodeableConcept>);
			var b_ = (CodeableConcept X) => FHIRHelpers_4_0_001.ToConcept(X);
			var c_ = context?.Operators.SelectOrNull<CodeableConcept, CqlConcept>(a_, b_);
			var d_ = this.Left();

			return context?.Operators.ConceptsInValueSet(c_, d_);
		};
		var n_ = context?.Operators.WhereOrNull<Condition>(l_, m_);
		var o_ = context?.Operators.ListUnion<Condition>(j_, n_);
		var p_ = (Condition LeftMastectomy) =>
		{
			var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(LeftMastectomy);
			var f_ = context?.Operators.Start(e_);
			var g_ = this.Measurement_Period();
			var h_ = context?.Operators.End(g_);

			return context?.Operators.SameOrBefore(f_, h_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(o_, p_);
	}

    [CqlDeclaration("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis() => __Left_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Value()
	{
		var k_ = this.Unilateral_Mastectomy_Left();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(k_, null);
		var m_ = (Procedure UnilateralMastectomyLeftPerformed) =>
		{
			var a_ = (UnilateralMastectomyLeftPerformed?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (UnilateralMastectomyLeftPerformed?.Performed as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.SameOrBefore(g_, i_, null);

			return context?.Operators.And(d_, j_);
		};

		return context?.Operators.WhereOrNull<Procedure>(l_, m_);
	}

    [CqlDeclaration("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure() => __Left_Mastectomy_Procedure.Value;

    private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Value()
	{
		var e_ = this.History_of_bilateral_mastectomy();
		var f_ = context?.DataRetriever.RetrieveByValueSet<Condition>(e_, null);
		var g_ = (Condition BilateralMastectomyHistory) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(BilateralMastectomyHistory);
			var b_ = context?.Operators.Start(a_);
			var c_ = this.Measurement_Period();
			var d_ = context?.Operators.End(c_);

			return context?.Operators.SameOrBefore(b_, d_, null);
		};

		return context?.Operators.WhereOrNull<Condition>(f_, g_);
	}

    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis() => __Bilateral_Mastectomy_Diagnosis.Value;

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Value()
	{
		var k_ = this.Bilateral_Mastectomy();
		var l_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(k_, null);
		var m_ = (Procedure BilateralMastectomyPerformed) =>
		{
			var a_ = (BilateralMastectomyPerformed?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("completed" as object));
			var e_ = (BilateralMastectomyPerformed?.Performed as object);
			var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = this.Measurement_Period();
			var i_ = context?.Operators.End(h_);
			var j_ = context?.Operators.SameOrBefore(g_, i_, null);

			return context?.Operators.And(d_, j_);
		};

		return context?.Operators.WhereOrNull<Procedure>(l_, m_);
	}

    [CqlDeclaration("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure() => __Bilateral_Mastectomy_Procedure.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = this.Right_Mastectomy_Diagnosis();
		var c_ = context?.Operators.ExistsInList<Condition>(b_);
		var d_ = this.Right_Mastectomy_Procedure();
		var e_ = context?.Operators.ExistsInList<Procedure>(d_);
		var f_ = context?.Operators.Or(c_, e_);
		var g_ = this.Left_Mastectomy_Diagnosis();
		var h_ = context?.Operators.ExistsInList<Condition>(g_);
		var i_ = this.Left_Mastectomy_Procedure();
		var j_ = context?.Operators.ExistsInList<Procedure>(i_);
		var k_ = context?.Operators.Or(h_, j_);
		var l_ = context?.Operators.And(f_, k_);
		var m_ = context?.Operators.Or(a_, l_);
		var n_ = this.Bilateral_Mastectomy_Diagnosis();
		var o_ = context?.Operators.ExistsInList<Condition>(n_);
		var p_ = context?.Operators.Or(m_, o_);
		var q_ = this.Bilateral_Mastectomy_Procedure();
		var r_ = context?.Operators.ExistsInList<Procedure>(q_);
		var s_ = context?.Operators.Or(p_, r_);
		var t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var u_ = context?.Operators.Or(s_, t_);
		var v_ = (this.Patient()?.BirthDateElement?.Value as object);
		var w_ = context?.Operators?.TypeConverter.Convert<CqlDate>(v_);
		var x_ = this.Measurement_Period();
		var y_ = context?.Operators.Start(x_);
		var z_ = context?.Operators.DateFrom(y_);
		var aa_ = context?.Operators.CalculateAgeAt(w_, z_, "year");
		var ab_ = (aa_ as object);
		var ac_ = ((int?)65 as object);
		var ad_ = context?.Operators.GreaterOrEqual(ab_, ac_);
		var ae_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var af_ = context?.Operators.And(ad_, ae_);
		var ag_ = context?.Operators.Or(u_, af_);
		var ah_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();

		return context?.Operators.Or(ag_, ah_);
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private bool? Observation_with_status_Value()
	{
		var z_ = this.Mammography();
		var aa_ = context?.DataRetriever.RetrieveByValueSet<Observation>(z_, null);
		var ab_ = (Observation Mammogram) =>
		{
			var a_ = (Mammogram?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = "appended";
			var g_ = new string[]
			{
				c_,
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(b_, h_);
			var j_ = (Mammogram?.Effective as object);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context?.Operators.End(k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.Quantity(27m, "months");
			var p_ = context?.Operators.Subtract(n_, o_);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.End(q_);
			var s_ = context?.Operators.Interval(p_, r_, true, true);
			var t_ = context?.Operators.ElementInInterval<CqlDateTime>(l_, s_, null);
			var u_ = this.Measurement_Period();
			var v_ = context?.Operators.End(u_);
			var w_ = (bool?)(v_ == null);
			var x_ = context?.Operators.Not(w_);
			var y_ = context?.Operators.And(t_, x_);

			return context?.Operators.And(i_, y_);
		};
		var ac_ = context?.Operators.WhereOrNull<Observation>(aa_, ab_);

		return context?.Operators.ExistsInList<Observation>(ac_);
	}

    [CqlDeclaration("Observation with status")]
    public bool? Observation_with_status() => __Observation_with_status.Value;

    private bool? Diagnostic_Report_with_status_Value()
	{
		var z_ = this.Mammography();
		var aa_ = context?.DataRetriever.RetrieveByValueSet<DiagnosticReport>(z_, null);
		var ab_ = (DiagnosticReport Mammogram) =>
		{
			var a_ = (Mammogram?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = "appended";
			var g_ = new string[]
			{
				c_,
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(b_, h_);
			var j_ = (Mammogram?.Effective as object);
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			var l_ = context?.Operators.End(k_);
			var m_ = this.Measurement_Period();
			var n_ = context?.Operators.End(m_);
			var o_ = context?.Operators.Quantity(27m, "months");
			var p_ = context?.Operators.Subtract(n_, o_);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.End(q_);
			var s_ = context?.Operators.Interval(p_, r_, true, true);
			var t_ = context?.Operators.ElementInInterval<CqlDateTime>(l_, s_, null);
			var u_ = this.Measurement_Period();
			var v_ = context?.Operators.End(u_);
			var w_ = (bool?)(v_ == null);
			var x_ = context?.Operators.Not(w_);
			var y_ = context?.Operators.And(t_, x_);

			return context?.Operators.And(i_, y_);
		};
		var ac_ = context?.Operators.WhereOrNull<DiagnosticReport>(aa_, ab_);

		return context?.Operators.ExistsInList<DiagnosticReport>(ac_);
	}

    [CqlDeclaration("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status() => __Diagnostic_Report_with_status.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Observation_with_status();
		var b_ = this.Diagnostic_Report_with_status();

		return context?.Operators.Or(a_, b_);
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Final_Numerator_Population_Value()
	{
		var a_ = this.Numerator();
		var b_ = this.Initial_Population();
		var c_ = context?.Operators.And(a_, b_);
		var d_ = this.Denominator();
		var e_ = context?.Operators.And(c_, d_);
		var f_ = this.Denominator_Exclusions();
		var g_ = context?.Operators.Not(f_);

		return context?.Operators.And(e_, g_);
	}

    [CqlDeclaration("Final Numerator Population")]
    public bool? Final_Numerator_Population() => __Final_Numerator_Population.Value;

    private bool? Observation_without_appropriate_status_Value()
	{
		var aa_ = this.Mammography();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<Observation>(aa_, null);
		var ac_ = (Observation Mammogram) =>
		{
			var a_ = (Mammogram?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = "appended";
			var g_ = new string[]
			{
				c_,
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(b_, h_);
			var j_ = context?.Operators.Not(i_);
			var k_ = (Mammogram?.Effective as object);
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(k_);
			var m_ = context?.Operators.End(l_);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.End(n_);
			var p_ = context?.Operators.Quantity(27m, "months");
			var q_ = context?.Operators.Subtract(o_, p_);
			var r_ = this.Measurement_Period();
			var s_ = context?.Operators.End(r_);
			var t_ = context?.Operators.Interval(q_, s_, true, true);
			var u_ = context?.Operators.ElementInInterval<CqlDateTime>(m_, t_, null);
			var v_ = this.Measurement_Period();
			var w_ = context?.Operators.End(v_);
			var x_ = (bool?)(w_ == null);
			var y_ = context?.Operators.Not(x_);
			var z_ = context?.Operators.And(u_, y_);

			return context?.Operators.And(j_, z_);
		};
		var ad_ = context?.Operators.WhereOrNull<Observation>(ab_, ac_);

		return context?.Operators.ExistsInList<Observation>(ad_);
	}

    [CqlDeclaration("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status() => __Observation_without_appropriate_status.Value;

    private bool? Diagnostic_Report_without_appropriate_status_Value()
	{
		var aa_ = this.Mammography();
		var ab_ = context?.DataRetriever.RetrieveByValueSet<DiagnosticReport>(aa_, null);
		var ac_ = (DiagnosticReport Mammogram) =>
		{
			var a_ = (Mammogram?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = "appended";
			var g_ = new string[]
			{
				c_,
				d_,
				e_,
				f_,
			};
			var h_ = (g_ as IEnumerable<string>);
			var i_ = context?.Operators.InList<string>(b_, h_);
			var j_ = context?.Operators.Not(i_);
			var k_ = (Mammogram?.Effective as object);
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(k_);
			var m_ = context?.Operators.End(l_);
			var n_ = this.Measurement_Period();
			var o_ = context?.Operators.End(n_);
			var p_ = context?.Operators.Quantity(27m, "months");
			var q_ = context?.Operators.Subtract(o_, p_);
			var r_ = this.Measurement_Period();
			var s_ = context?.Operators.End(r_);
			var t_ = context?.Operators.Interval(q_, s_, true, true);
			var u_ = context?.Operators.ElementInInterval<CqlDateTime>(m_, t_, null);
			var v_ = this.Measurement_Period();
			var w_ = context?.Operators.End(v_);
			var x_ = (bool?)(w_ == null);
			var y_ = context?.Operators.Not(x_);
			var z_ = context?.Operators.And(u_, y_);

			return context?.Operators.And(j_, z_);
		};
		var ad_ = context?.Operators.WhereOrNull<DiagnosticReport>(ab_, ac_);

		return context?.Operators.ExistsInList<DiagnosticReport>(ad_);
	}

    [CqlDeclaration("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status() => __Diagnostic_Report_without_appropriate_status.Value;

}