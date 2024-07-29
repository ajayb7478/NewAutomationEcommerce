Feature: UserAuthentication

A short summary of the feature

@tag1
Scenario: Valid Login
    Given I launch the website
    When I enter the user name into the text box "standard_user"
    And I enter the password into the password box "secret_sauce"
    And I login
    Then I verify if I have logged in or not
    And I log out and verify if I have logged out

Scenario: Incorrect Username or Password
<<<<<<< HEAD
    Given I launch the website
    When I enter the user name into the text box "locked"
    And I enter the password into the password box "secrfdh"
    And I login
    Then I verify if I get an error message
=======
	Given I open a browser
	When I navigate to "https://www.saucedemo.com"
	Then I type the user name into the text box "locked_out"
	Then I type the password into the password box "secret_"
	Then I login
	Then I verify if I get an error message
>>>>>>> 09fa4b70d02b91561e51be4dbe5d719d8fe72a58

	

