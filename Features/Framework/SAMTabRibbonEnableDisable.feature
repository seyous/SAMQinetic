Feature: To Validate Ribbon Object for SAM Tab is visible

	
@EnableDisableRibbon
Scenario Outline: SAM Ribbon enabled and disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the SAM Tab
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon                   | visibility |
| All Scenarios            | Disabled  |
| Update Results           | Disabled  |




