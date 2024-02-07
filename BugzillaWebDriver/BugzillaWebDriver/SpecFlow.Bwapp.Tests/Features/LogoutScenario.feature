Feature: LogoutScenario

Scenario of a simple logout of application

Scenario: LogoutScenario
	Given User is on Home Page
	And Login and password inputs are visible
	When I provide the login and password and click on Login button
	Then User should be on portal page
	Given Logout link is visible
	When I click on logout link
	And I click on OK on pop-up
	Then User is on login page
