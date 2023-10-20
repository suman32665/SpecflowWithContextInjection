Feature: 3.VerifyBalance

@regression @verifybalance
Scenario: Verify Balance
	Given I navigate to ParaBank application
	And I enter username and password

	When I click login button
	And I click on Accounts Overview Hyperlink

	Then the following values should be displayed in Account Overview Page
		| Account | Balance   | AvailableAmount |
		| 14676   | $50000.00 | $50000.00       |