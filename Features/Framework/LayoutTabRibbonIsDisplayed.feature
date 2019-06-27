Feature: To Validate Layout Ribbon is displayed
	

@DisplayedTabRibbon
Scenario Outline: Layout Ribbon is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the layout Tab
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Show   |
| Help   |


