@Framework @Done
Feature: To Validate Layout Ribbon is displayed
	

@DisplayedTabRibbon
Scenario Outline: Layout Ribbon is Displayed
Given a user opens SAM
And the user can click on the OK button
When the user click the layout Tab
Then the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Show   |
#| Help   |


