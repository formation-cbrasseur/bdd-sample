Feature: LoginFailWhenWrongParametersSuppliedFeature
	Check if login fail with wrong parameters supplied

Scenario: Try to Login with wrong parameters
Given User is at Home Page
	And File a Bug Link should be visible
	When I click on File a Bug Link
	Then User should be at Login Page
	When I provide the username "wrongmail" and password "wrongpassword" 
	And click on Login button
	Then User Should be at Wrong Password Page
