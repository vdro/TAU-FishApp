﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace IntegrationTests.CoreEssentials.Invoices
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CalculateDueDateForPaymentFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "CalculateDueDateForPayment.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Calculate Due Date For Payment", "\tIn order to establish the date of payment\r\n\tAs an administration or accounting s" +
                    "pecialist\r\n\tI want the payment date to be calculated automatically", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Calculate Due Date For Payment")))
            {
                global::IntegrationTests.CoreEssentials.Invoices.CalculateDueDateForPaymentFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("a user has the \"INKUBIT - Basic User\" user role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("a user has the \"INKUBIT - Sales Person\" user role", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        public virtual void InvoiceCreation(string invoiceDate, string daysUntilPayment, string dueDateForPayment, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invoice creation", exampleTags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 11
 testRunner.When("a user creates an invoice with mandatory fields filled out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.And(string.Format("saves it with invoiceDate:{0} and daysUntilPayment:{1}", invoiceDate, daysUntilPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.Then(string.Format("Due Date for Payments should be {0}", dueDateForPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice creation: 2019-01-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2019-01-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Invoice Date", "2019-01-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Days until payment", "14")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-01-15")]
        public virtual void InvoiceCreation_2019_01_01()
        {
#line 10
this.InvoiceCreation("2019-01-01", "14", "2019-01-15", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice creation: 2019-02-28")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2019-02-28")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Invoice Date", "2019-02-28")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Days until payment", "14")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-03-14")]
        public virtual void InvoiceCreation_2019_02_28()
        {
#line 10
this.InvoiceCreation("2019-02-28", "14", "2019-03-14", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice creation: 2019-12-31")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2019-12-31")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Invoice Date", "2019-12-31")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Days until payment", "30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2020-01-30")]
        public virtual void InvoiceCreation_2019_12_31()
        {
#line 10
this.InvoiceCreation("2019-12-31", "30", "2020-01-30", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice state is updated to Sent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        public virtual void InvoiceStateIsUpdatedToSent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invoice state is updated to Sent", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 22
 testRunner.When("a user creates an invoice with mandatory fields filled out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("saves it with invoiceDate:2019-06-01 and daysUntilPayment:3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.But("later updates statusReason to Sent_Active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 25
 testRunner.Then("Due Date for Payments Internal should be 2019-06-07", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void InvoiceStateImpactOnDueDateForPayment(string statusReason, string _1StReminder, string _2NdReminder, string _3RdReminder, string dueDateForPayment, string dueDateForPaymentINTERNAL, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invoice state impact on Due Date For Payment", exampleTags);
#line 27
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 28
 testRunner.When("a user creates an invoice with mandatory fields filled out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.And(string.Format("1stReminderDate:{0}, 2ndReminderDate:{1} and 3rdReminderDate:{2}", _1StReminder, _2NdReminder, _3RdReminder), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And(string.Format("invoice is in {0}", statusReason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("saves it with invoiceDate:2019-06-01 and daysUntilPayment:7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then(string.Format("Due Date for Payments should be {0}", dueDateForPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.Then(string.Format("Due Date for Payments Internal should be {0}", dueDateForPaymentINTERNAL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice state impact on Due Date For Payment: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "Draft_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:1st Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:2nd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:3rd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-06-08")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-06-08")]
        public virtual void InvoiceStateImpactOnDueDateForPayment_Variant0()
        {
#line 27
this.InvoiceStateImpactOnDueDateForPayment("Draft_Active", "", "", "", "2019-06-08", "2019-06-08", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice state impact on Due Date For Payment: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "Sent_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:1st Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:2nd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:3rd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-06-08")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-06-11")]
        public virtual void InvoiceStateImpactOnDueDateForPayment_Variant1()
        {
#line 27
this.InvoiceStateImpactOnDueDateForPayment("Sent_Active", "", "", "", "2019-06-08", "2019-06-11", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice state impact on Due Date For Payment: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "_1stReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:1st Reminder", "2019-07-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:2nd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:3rd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-06-08")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-07-09")]
        public virtual void InvoiceStateImpactOnDueDateForPayment_Variant2()
        {
#line 27
this.InvoiceStateImpactOnDueDateForPayment("_1stReminder_Active", "2019-07-01", "", "", "2019-06-08", "2019-07-09", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice state impact on Due Date For Payment: Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "_1stReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:1st Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:2nd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:3rd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-06-08")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-07-09")]
        public virtual void InvoiceStateImpactOnDueDateForPayment_Variant3()
        {
#line 27
this.InvoiceStateImpactOnDueDateForPayment("_1stReminder_Active", "", "", "", "2019-06-08", "2019-07-09", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice state impact on Due Date For Payment: Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "_2ndReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:1st Reminder", "2019-07-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:2nd Reminder", "2019-08-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:3rd Reminder", "")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-06-08")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-08-09")]
        public virtual void InvoiceStateImpactOnDueDateForPayment_Variant4()
        {
#line 27
this.InvoiceStateImpactOnDueDateForPayment("_2ndReminder_Active", "2019-07-01", "2019-08-01", "", "2019-06-08", "2019-08-09", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice state impact on Due Date For Payment: Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "_3rdReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:1st Reminder", "2019-07-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:2nd Reminder", "2019-08-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:3rd Reminder", "2019-09-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-06-08")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-09-09")]
        public virtual void InvoiceStateImpactOnDueDateForPayment_Variant5()
        {
#line 27
this.InvoiceStateImpactOnDueDateForPayment("_3rdReminder_Active", "2019-07-01", "2019-08-01", "2019-09-01", "2019-06-08", "2019-09-09", ((string[])(null)));
#line hidden
        }
        
        public virtual void InvoiceStateStatusReasonChangeImpactOnDueDateForPayment(string statusReason, string dueDateForPaymentINTERNAL, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invoice State/Status Reason change impact on Due Date For Payment", exampleTags);
#line 44
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 45
 testRunner.When("a user creates an invoice with mandatory fields filled out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.And("saves it with invoiceDate:2019-06-01 and daysUntilPayment:7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.But(string.Format("later updates statusReason to {0}", statusReason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 48
 testRunner.Then("respective reminder date is set to today", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And(string.Format("Due Date for Payments Internal should be {0}", dueDateForPaymentINTERNAL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice State/Status Reason change impact on Due Date For Payment: Draft_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Draft_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "Draft_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-06-08")]
        public virtual void InvoiceStateStatusReasonChangeImpactOnDueDateForPayment_Draft_Active()
        {
#line 44
this.InvoiceStateStatusReasonChangeImpactOnDueDateForPayment("Draft_Active", "2019-06-08", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice State/Status Reason change impact on Due Date For Payment: Sent_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Sent_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "Sent_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "2019-06-11")]
        public virtual void InvoiceStateStatusReasonChangeImpactOnDueDateForPayment_Sent_Active()
        {
#line 44
this.InvoiceStateStatusReasonChangeImpactOnDueDateForPayment("Sent_Active", "2019-06-11", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice State/Status Reason change impact on Due Date For Payment: _1stReminder_A" +
            "ctive")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "_1stReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "_1stReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "Today + 8days")]
        public virtual void InvoiceStateStatusReasonChangeImpactOnDueDateForPayment_1StReminder_Active()
        {
#line 44
this.InvoiceStateStatusReasonChangeImpactOnDueDateForPayment("_1stReminder_Active", "Today + 8days", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice State/Status Reason change impact on Due Date For Payment: _2ndReminder_A" +
            "ctive")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "_2ndReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "_2ndReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "Today + 8days")]
        public virtual void InvoiceStateStatusReasonChangeImpactOnDueDateForPayment_2NdReminder_Active()
        {
#line 44
this.InvoiceStateStatusReasonChangeImpactOnDueDateForPayment("_2ndReminder_Active", "Today + 8days", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice State/Status Reason change impact on Due Date For Payment: _3rdReminder_A" +
            "ctive")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "_3rdReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Status Reason", "_3rdReminder_Active")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment INTERNAL", "Today + 8days")]
        public virtual void InvoiceStateStatusReasonChangeImpactOnDueDateForPayment_3RdReminder_Active()
        {
#line 44
this.InvoiceStateStatusReasonChangeImpactOnDueDateForPayment("_3rdReminder_Active", "Today + 8days", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice creation with missing \"Days until payment\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        public virtual void InvoiceCreationWithMissingDaysUntilPayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invoice creation with missing \"Days until payment\"", ((string[])(null)));
#line 59
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 60
 testRunner.When("a user creates an invoice with mandatory fields filled out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.But("saves it with \'2019-01-01\' as Invoice Date and without Days until payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 62
 testRunner.Then("invoice is not saved and error is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice creation with missing \"Invoice Date\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        public virtual void InvoiceCreationWithMissingInvoiceDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invoice creation with missing \"Invoice Date\"", ((string[])(null)));
#line 64
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 65
 testRunner.When("a user creates an invoice with mandatory fields filled out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.But("saves it with 14 as Days until payment and without Invoice Date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 67
 testRunner.Then("invoice is not saved and error is thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void InvoiceDateUpdate(string invoiceDate, string updatedInvoiceDate, string daysUntilPayment, string dueDateForPayment, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Invoice date update", exampleTags);
#line 69
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 70
 testRunner.When("a user creates an invoice with mandatory fields filled out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And(string.Format("saves it with invoiceDate:{0} and daysUntilPayment:{1}", invoiceDate, daysUntilPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.But(string.Format("later updates Invoice Date to {0}", updatedInvoiceDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 73
 testRunner.Then(string.Format("Due Date for Payments should be {0}", dueDateForPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice date update: 2019-01-11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2019-01-11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Invoice Date", "2019-01-11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Updated Invoice Date", "2019-01-08")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Days until payment", "7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-01-15")]
        public virtual void InvoiceDateUpdate_2019_01_11()
        {
#line 69
this.InvoiceDateUpdate("2019-01-11", "2019-01-08", "7", "2019-01-15", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice date update: 2019-02-24")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2019-02-24")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Invoice Date", "2019-02-24")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Updated Invoice Date", "2019-02-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Days until payment", "14")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-02-15")]
        public virtual void InvoiceDateUpdate_2019_02_24()
        {
#line 69
this.InvoiceDateUpdate("2019-02-24", "2019-02-01", "14", "2019-02-15", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Invoice date update: 2019-10-30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calculate Due Date For Payment")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2019-10-30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Invoice Date", "2019-10-30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Updated Invoice Date", "2019-11-01")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Days until payment", "30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Due Date for payment", "2019-12-01")]
        public virtual void InvoiceDateUpdate_2019_10_30()
        {
#line 69
this.InvoiceDateUpdate("2019-10-30", "2019-11-01", "30", "2019-12-01", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
