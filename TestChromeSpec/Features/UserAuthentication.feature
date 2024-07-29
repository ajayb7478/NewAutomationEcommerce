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
    Given I launch the website
    When I enter the user name into the text box "locked"
    And I enter the password into the password box "secrfdh"
    And I login
    Then I verify if I get an error message

	

