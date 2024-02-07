Feature: LoginScenario

Simple login feature

Scenario: LoginScenario
	Given User is on Home Page
	And Login and password inputs are visible
	When I provide the login and password and click on Login button
	Then User should be on portal page
