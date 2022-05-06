Feature: HomePage

Scenario Outline: Learn More button Navigation
	Given I am on the Home Page
	When I click Learn more button under the <Heading> heading
	Then I am on the <ToPage> Page

	Examples: 
	| Heading                             | ToPage   |
	| Natural Bodybuilding Workout        | Training |
	| The basics of Vegan Nutrition       | Diet     |
	| Watch, Practice and Learn to Lift!  | Exercise |
	| The basics of Optimal Vegan Fatloss | Fatloss  |

Scenario Outline: Home Page Navigation 
	Given I am on the Home Page
	When I click on the <ToPage> Nav Menu Item
	Then I am on the <ToPage> Page
	Examples: 
	| ToPage   |
	| Home     |
	| Fatloss  |
	| Exercise |
	| Diet     |
	| Training |