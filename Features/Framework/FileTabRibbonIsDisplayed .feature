Feature: To Validate File Tab Ribbon is displayed
	

@DisplayedTabRibbon
Scenario Outline: File Tab Ribbon is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the File Tab
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Open   |


