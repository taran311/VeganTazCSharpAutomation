Feature: DietPage

Scenario Outline: Diet Page Navigation 
Given I am on the Diet Page
When I click on the <ToPage> Nav Menu Item
Then I am on the <ToPage> Page
Examples: 
| ToPage   |
| Home     |
| Fatloss  |
| Exercise |
| Diet     |
| Training |