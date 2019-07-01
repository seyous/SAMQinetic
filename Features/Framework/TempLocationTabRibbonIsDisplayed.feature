@Framework @Done
Feature: To Validate Temp Location Ribbon is displayed



@DisplayedTabRibbon
Scenario Outline: Temp Location Ribbon is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click on the Temp Location Tab
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon        |
| Validation    |
| Remove Traces |