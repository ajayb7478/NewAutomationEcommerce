Feature: SimpleAmazonSearch

A short summary of the feature

@production
Scenario: Search for graphics cards
    Given I open the browser
    When I navigate to "https://www.amazon.in/ref=nav_logo"
    And I search for "graphics cards"
    Then I should see search results related to graphics cards

Scenario: Search for laptops
  Given I open the browser
  When I navigate to "https://www.amazon.in/ref=nav_logo"
  And I search for "laptops"
  Then I should see search results related to laptops