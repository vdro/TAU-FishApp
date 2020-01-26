using IBS.Internal.Tests.Common;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using IBS.Internal.Tests.Common.ProxyClasses;
using TechTalk.SpecFlow;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using static IBS.Internal.Tests.Common.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace IntegrationTests.CoreEssentials.Invoices
{
    [Binding]
    public class CalculateDueDateForPaymentSteps
    {
        private TestHelper testHelper;
        private TestDataHelper testData;
        private static CrmServiceClient adminContext;
        private static List<EntityRef> toBeCleaned = new List<EntityRef>();
        private Invoice invoice;
        private Invoice savedInvoice;
        private Exception caughtException;
        private readonly ScenarioContext injectedContext;

        public CalculateDueDateForPaymentSteps(ScenarioContext injectedContext)
        {
            if (!injectedContext.TryGetValue("TestHelper", out testHelper))
            {
                testHelper = new TestHelper();
                injectedContext.Set(testHelper);
            }
            testData = new TestDataHelper(testHelper);
            adminContext = testHelper.AdminUserService;
            this.injectedContext = injectedContext;
        }

        [AfterFeatureAttribute]
        public static void CleanUp()
        {
            //TODO: this needs to be refactored (todo example)
            foreach (var entity in toBeCleaned)
            {
                adminContext.Delete(entity.Name, entity.Id);
            }
        }


        [When(@"a user creates an invoice with mandatory fields filled out")]
        public void WhenAUserCreatesAnInvoiceWithMandatoryFieldsFilledOut()
        {
            //CLA Test Company (on Dev)
            var customerRef = new EntityReference(
                    Account.LogicalName, new Guid("{F71861E2-6734-E911-A833-000D3A2DDB03}"));
            //CLA Test Contact (on Dev)
            var contactRef = new EntityReference(
                Contact.LogicalName, new Guid("{052B01E3-D487-E911-A83D-000D3A2DDC03}"));
            //Euro (on Dev)
            var currencyRef = new EntityReference(
                    "transactioncurrency", new Guid("{EF7EC02E-8817-E911-A95F-000D3A44AE5A}"));
            //Microsoft 2019 - Germany (on Dev)
            var priceListRef = new EntityReference(
                    "pricelevel", new Guid("{79E68A7B-363F-E911-A83B-000D3A2DDCBB}"));
            invoice = new Invoice
            {
                Subject = "Integration test invoice for CalculateDueDateForPayment",
                Customer = customerRef,
                Account = customerRef,
                Currency = currencyRef,
                PriceList = priceListRef,
                PeriodFrom = DateTime.Today,
                PeriodTo = DateTime.Today.AddDays(7),
                FullMonthCoverage = false, //not important
                PaymentMethod = Invoice.ePaymentMethod.BankTransfer, //not important
                PricesLocked = false, //not important
                InvoiceType = Invoice.eInvoiceType.ExternalAccount,
                //BusinessUnit = 
                //TODO: what other fields are required ?
            };
        }

        [When(@"1stReminderDate:(.*), 2ndReminderDate:(.*) and 3rdReminderDate:(.*)")]
        public void WhenAnd(string _1streminderdateStr, string _2ndinvoicedateStr, string _3rdinvoicedateStr)
        {
            invoice._1stReminderDate = string.IsNullOrEmpty(_1streminderdateStr) ? (DateTime?)null : DateTime.Parse(_1streminderdateStr);
            invoice._2ndReminderDate = string.IsNullOrEmpty(_2ndinvoicedateStr) ? (DateTime?)null : DateTime.Parse(_2ndinvoicedateStr);
            invoice._3rdReminderDate = string.IsNullOrEmpty(_3rdinvoicedateStr) ? (DateTime?)null : DateTime.Parse(_3rdinvoicedateStr);
        }

        [When(@"invoice is in (.*)")]
        public void WhenInvoiceIsIn(Invoice.eStatusReason statusReason)
        {
            invoice.StatusReason = statusReason;
        }

        [When(@"saves it with invoiceDate:(.*) and daysUntilPayment:(.*)")]
        public void WhenAUserSavesAnInvoiceWithAnd(DateTime invoiceDate, int daysUntilPayment)
        {
            invoice.InvoiceDate = invoiceDate;
            invoice.DaysUntilPayment = daysUntilPayment;
            SaveInvoice();
        }

        [When(@"saves it with '(.*)' as Invoice Date and without Days until payment")]
        public void WhenSavesItWithAsInvoiceDateAndWithoutDaysUntilPayment(DateTime invoiceDate)
        {
            invoice.InvoiceDate = invoiceDate;
            SaveInvoice();
        }

        [When(@"saves it with (.*) as Days until payment and without Invoice Date")]
        public void WhenSavesItWithAsDaysUntilPaymentAndWithoutInvoiceDate(int daysUntilPayment)
        {
            invoice.DaysUntilPayment = daysUntilPayment;
            SaveInvoice();
        }

        [When(@"later updates Invoice Date to (.*)")]
        public void WhenLaterUpdatesInvoiceDateTo(DateTime invoiceDate)
        {
            invoice.InvoiceDate = invoiceDate;
            testHelper.TestUserService.Update(invoice);
        }

        [When(@"later updates statusReason to (.*)")]
        public void WhenLaterUpdatesStatusReasonTo(Invoice.eStatusReason statusReason)
        {
            invoice.StatusReason = statusReason;
            testHelper.TestUserService.Update(invoice);
        }



        [Then(@"Due Date for Payments should be (.*)")]
        public void ThenDueDateForPaymentsShouldBe(DateTime paymentDueDate)
        {
            FetchSavedInvoiceIfNotDoneYet();
            Assert.AreEqual(paymentDueDate, savedInvoice.DueDateForPayment);
        }

        [Then(@"Due Date for Payments and Due Date for Payments Internal are not set")]
        public void ThenDueDateForPaymentsIsNotSet()
        {
            FetchSavedInvoiceIfNotDoneYet();
            Assert.IsFalse(savedInvoice.DueDateForPaymentINTERNAL.HasValue);
            Assert.IsFalse(savedInvoice.DueDateForPayment.HasValue);
        }

        [Then(@"Due Date for Payments Internal should be (.*)")]
        //public void ThenDueDateForPaymentsInternalShouldBe(DateTime paymentDueDate)
        public void ThenDueDateForPaymentsInternalShouldBe(string paymentDueDateStr)
        {
            FetchSavedInvoiceIfNotDoneYet();
            DateTime paymentDueDate;
            if (!DateTime.TryParse(paymentDueDateStr, out paymentDueDate))
            {
                var regexp = new Regex("Today \\+ ([1-9])days");
                var val = regexp.Match(paymentDueDateStr).Groups[1].Value;
                var days = Double.Parse(val);
                paymentDueDate = DateTime.Today.Date.AddDays(days);
            }
            Assert.AreEqual(paymentDueDate, savedInvoice.DueDateForPaymentINTERNAL);
        }
        
        [Then(@"invoice is not saved and error is thrown")]
        public void ThenInvoiceIsNotSavedAndErrorIsThrown()
        {
            Assert.IsNotNull(caughtException);
            Assert.AreEqual(Guid.Empty, invoice.Id);
        }

        [Then(@"respective reminder date is set to today")]
        public void ThenRespectiveReminderDateIsSetToToday()
        {
            FetchSavedInvoiceIfNotDoneYet();
            switch (savedInvoice.StatusReason)
            {
                case Invoice.eStatusReason._1stReminder_Active:
                    Assert.AreEqual(DateTime.Today.Date, savedInvoice._1stReminderDate.Value.Date);
                    break;
                case Invoice.eStatusReason._2ndReminder_Active:
                    Assert.AreEqual(DateTime.Today.Date, savedInvoice._2ndReminderDate.Value.Date);
                    break;
                case Invoice.eStatusReason._3rdReminder_Active:
                    Assert.AreEqual(DateTime.Today.Date, savedInvoice._3rdReminderDate.Value.Date);
                    break;
            }
        }



        private void SaveInvoice()
        {
            try
            {
                invoice.InvoiceId = testHelper.TestUserService.Create(invoice);
                toBeCleaned.Add(new EntityRef
                {
                    Id = invoice.InvoiceId,
                    Name = Invoice.LogicalName
                });
            }
            catch (Exception ex)
            {
                caughtException = ex;
            }
        }

        private void FetchSavedInvoiceIfNotDoneYet()
        {
            if (savedInvoice == null)
            {
                savedInvoice = testHelper.TestUserService.Retrieve(Invoice.LogicalName, invoice.InvoiceId, new ColumnSet(true)) as Invoice;
            }
        }

    }
}
