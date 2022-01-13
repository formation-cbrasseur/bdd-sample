﻿Feature: Login and Create Bug Feature of the BugZila web page

Background: Pre-Condition Login with Link File a Bug
	Given User is at Home Page
	And File a Bug Link should be visible
	When I click on File a Bug Link
	Then User should be at Login Page
	When I provide the username, password and click on Login button
	Then User Should be at Enter Bug page

Scenario: Logout scenario of BugZilla
	When I click on Logout button
	Then User should be logged out and should be at Home Page


Scenario: Create Bug scenario of Bugzilla
	When I provide the severity, hardware, platform and summary
	And click on Submit button
	Then Bug should get created
	And User should be at Bug Detail page
	When I click on Logout button
	Then User should be logged out and should be at Home Page