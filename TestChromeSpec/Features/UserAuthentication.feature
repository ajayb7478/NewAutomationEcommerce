Feature: UserAuthentication

A short summary of the feature

@tag1
Scenario: Valid Login
	Given I open a browser
	When I navigate to "https://www.saucedemo.com"
	Then I type the user name into the text box "standard_user"
	Then I type the password into the password box "secret_sauce"
	Then I login
	Then I verify if I have logged in or not
	Then I log out and verify if I have logged out


