@Framework @Done
Feature: To Validate File Tab Ribbon is displayed
	

@DisplayedTabRibbon
Scenario Outline: File Tab Ribbon is Displayed
	Given a user opens SAM
	And the user can click on the OK button
	When the user click the File Tab
	Then the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Open   |


