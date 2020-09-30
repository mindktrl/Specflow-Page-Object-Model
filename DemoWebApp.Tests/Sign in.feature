Feature: Sign in
	As a customer with an account 
	I want to be able to sign in using my user name and password
	So that I can access and manage my account.

Scenario: Test that the user can sign in with valid credentials then sign out
	Given the user is on the sign in page
	When the user enters username "testuser"
	And the user enters a password "pw"
	And the user clicks the login button
	Then the user should be logged in
	And the user can sign out by clicking the logout button