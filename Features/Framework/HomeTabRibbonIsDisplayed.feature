@Framework @Done
Feature: To Validate Home Tab Ribbon is displayed
	

@DisplayedTabRibbon
Scenario Outline: Home Tab Ribbon is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon           |
| Auto Recalculate |


