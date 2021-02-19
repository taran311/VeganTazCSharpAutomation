Feature: TrainingPage

Scenario Outline: Training Page Navigation 
Given I am on the Training Page
When I click on the <ToPage> Nav Menu Item
Then I am on the <ToPage> Page
Examples: 
| ToPage   |
| Home     |
| Fatloss  |
| Exercise |
| Diet     |
| Training |