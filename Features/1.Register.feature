Feature: 1.Register


@regression @register
Scenario: Register a new customer
	Given I navigate to ParaBank application
	And I click on Register for new registration
	And I fill up the sign up form
		| FirstName | LastName | Address   | City      | State   | ZipCode | Phone   | SSN     |
		| Suman     | Maharjan | Kathmandu | Kathmandu | Bagmati | 1111    | 3421341 | 2341132 |

	When I click on Register button
	Then user should be landed in Welcome page with heading 'Welcome username'
	And the account created successfully message should be displayed

