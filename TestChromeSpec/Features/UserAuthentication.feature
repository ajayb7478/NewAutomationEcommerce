Feature: UserAuthentication

A short summary of the feature

@tag1
Scenario: Valid Login
Given I open a browser
When I navigate to "https://www.amazon.com"
And I type the user name into the text box "standard_user"
Then I type the password into the password box "secret_sauce"
Then I login
Then I verify if I have logged in or not