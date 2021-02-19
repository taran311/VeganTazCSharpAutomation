Feature: Fatloss

Scenario: Fatloss Page displays Work In Progress Alert Message
Given I am on the Fatloss Page
Then I see an Alert with text 'Work In Progress! This page will be hosting my Fatloss e-book upon it's release.'

Scenario Outline: Fatloss Page Navigation 
Given I am on the Fatloss Page
When I click on the <ToPage> Nav Menu Item
Then I am on the <ToPage> Page
Examples: 
| ToPage   |
| Home     |
| Fatloss  |
| Exercise |
| Diet     |
| Training |