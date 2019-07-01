@Framework @Done
Feature: To Validate Settings Tab Ribbon is displayed



@DisplayedTabRibbon
Scenario Outline: Settings Tab Ribbon is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the Settings Tab
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Graphs |
| Legend |