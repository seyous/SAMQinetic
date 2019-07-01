@Framework @Done
Feature: To Validate Quick Access Toolbar Ribbon is displayed
	

@DisplayedTabRibbon
Scenario Outline: Quick Access Toolbar Ribbon is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Save   |


