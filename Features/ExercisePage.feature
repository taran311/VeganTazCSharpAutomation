Feature: ExercisePage

Scenario Outline: AutoComplete Widget generates Options correctly
	Given I am on the Exercise Page
	When I enter '<SearchString>' in the Exercise field
	Then the '<SearchSuggestions>' Search Suggestions are displayed
	Examples: 
	| SearchString | SearchSuggestions                        |
	| Deadlifts    | Deadlifts                                |
	| Squats       | Front Squats, Squats                     |
	| Curls        | Barbell Curls, Bicep Curls, Hammer Curls |
	| PullUps      | PullUps                                  |

Scenario Outline: AutoComplete Widget Selection shows correct data
	Given I am on the Exercise Page
	When I enter '<SearchString>' in the Exercise field
	And I click '<SearchString>' Search Suggestion
	Then the '<SearchString>' video is displayed alongside text '<text>'
	Examples: 
	| SearchString | text                                     |
	| Deadlifts    | targets the main muscle group Lower Back |
	| Front Squats | targets the main muscle group Quadriceps |
	| Hammer Curls | targets the main muscle group Bicep      |
	| PullUps      | targets the main muscle group Lats       |

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