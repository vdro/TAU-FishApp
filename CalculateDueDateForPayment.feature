Feature: Calculate Due Date For Payment
	In order to establish the date of payment
	As an administration or accounting specialist
	I want the payment date to be calculated automatically

Background:
	Given a user has the "INKUBIT - Basic User" user role
	And a user has the "INKUBIT - Sales Person" user role

Scenario Outline: Invoice creation
	When a user creates an invoice with mandatory fields filled out
	And saves it with invoiceDate:<Invoice Date> and daysUntilPayment:<Days until payment>
	Then Due Date for Payments should be <Due Date for payment>

	Examples:
		| Invoice Date | Days until payment | Due Date for payment |
		| 2019-01-01   | 14                 | 2019-01-15           |
		| 2019-02-28   | 14                 | 2019-03-14           |
		| 2019-12-31   | 30                 | 2020-01-30           |

Scenario: Invoice state is updated to Sent
	When a user creates an invoice with mandatory fields filled out
	And saves it with invoiceDate:2019-06-01 and daysUntilPayment:3
	But later updates statusReason to Sent_Active
	Then Due Date for Payments Internal should be 2019-06-07

Scenario Outline: Invoice state impact on Due Date For Payment
	When a user creates an invoice with mandatory fields filled out
	And 1stReminderDate:<1st Reminder>, 2ndReminderDate:<2nd Reminder> and 3rdReminderDate:<3rd Reminder>
	And invoice is in <Status Reason>
	And saves it with invoiceDate:2019-06-01 and daysUntilPayment:7
	Then Due Date for Payments should be <Due Date for payment>
	Then Due Date for Payments Internal should be <Due Date for payment INTERNAL>

	Examples:
		| Status Reason       | 1st Reminder | 2nd Reminder | 3rd Reminder | Due Date for payment | Due Date for payment INTERNAL |
		| Draft_Active        |              |              |              | 2019-06-08           | 2019-06-08                    |
		| Sent_Active         |              |              |              | 2019-06-08           | 2019-06-11                    |
		| _1stReminder_Active | 2019-07-01   |              |              | 2019-06-08           | 2019-07-09                    |
		| _1stReminder_Active |              |              |              | 2019-06-08           | 2019-07-09                    |
		| _2ndReminder_Active | 2019-07-01   | 2019-08-01   |              | 2019-06-08           | 2019-08-09                    |
		| _3rdReminder_Active | 2019-07-01   | 2019-08-01   | 2019-09-01   | 2019-06-08           | 2019-09-09                    |

Scenario Outline: Invoice State/Status Reason change impact on Due Date For Payment
	When a user creates an invoice with mandatory fields filled out
	And saves it with invoiceDate:2019-06-01 and daysUntilPayment:7
	But later updates statusReason to <Status Reason>
	Then respective reminder date is set to today
	And Due Date for Payments Internal should be <Due Date for payment INTERNAL>

	Examples:
		| Status Reason       | Due Date for payment INTERNAL |
		| Draft_Active        | 2019-06-08                    |
		| Sent_Active         | 2019-06-11                    |
		| _1stReminder_Active | Today + 8days                 |
		| _2ndReminder_Active | Today + 8days                 |
		| _3rdReminder_Active | Today + 8days                 |

Scenario: Invoice creation with missing "Days until payment"
	When a user creates an invoice with mandatory fields filled out
	But saves it with '2019-01-01' as Invoice Date and without Days until payment
	Then invoice is not saved and error is thrown

Scenario: Invoice creation with missing "Invoice Date"
	When a user creates an invoice with mandatory fields filled out
	But saves it with 14 as Days until payment and without Invoice Date
	Then invoice is not saved and error is thrown

Scenario Outline: Invoice date update
	When a user creates an invoice with mandatory fields filled out
	And saves it with invoiceDate:<Invoice Date> and daysUntilPayment:<Days until payment>
	But later updates Invoice Date to <Updated Invoice Date>
	Then Due Date for Payments should be <Due Date for payment>

	Examples:
		| Invoice Date | Updated Invoice Date | Days until payment | Due Date for payment |
		| 2019-01-11   | 2019-01-08           | 7                  | 2019-01-15           |
		| 2019-02-24   | 2019-02-01           | 14                 | 2019-02-15           |
		| 2019-10-30   | 2019-11-01           | 30                 | 2019-12-01           |