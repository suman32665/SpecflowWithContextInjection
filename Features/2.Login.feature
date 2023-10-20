Feature: 2.Login

@regression @login
Scenario: Login to the system
	Given I navigate to ParaBank application
	And I enter username and password

	When I click login button
	Then the user should be landed in AccountOverview page

	When I click logout button
	Then the user should be redirected to login page
