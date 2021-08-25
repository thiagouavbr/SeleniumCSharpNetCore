Feature: Login
	Simple calculator for adding two numbers

@Login
Scenario: Login with the standard user and password
	Given access the home page
	And Click Login Page
	And type username and password
	| UserName | Password |
	| admin    | password |
	And Click on the Login button
	Then the Logoff button is shown