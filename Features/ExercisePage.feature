Feature: ExercisePage

#Scenario Outline: AutoComplete Widget generates Options correctly
#Given I am on the Exercise Page
#When I enter '<SearchString>' in the Exercise field
#Then the '<SearchSuggestions>' Search Suggestions are displayed
#Examples: 
#| SearchString | SearchSuggestions                        |
#| Deadlifts    | Deadlifts                                |
#| Squats       | Squats, Front Squats                     |
#| Curls        | Bicep Curls, Hammer Curls, Barbell Curls |
#| PullUps      | PullUps                                  |

Scenario Outline: Exercise Page Navigation 
Given I am on the Exercise Page
When I click on the <ToPage> Nav Menu Item
Then I am on the <ToPage> Page
Examples: 
| ToPage   |
| Home     |
| Fatloss  |
| Exercise |
| Diet     |
| Training |