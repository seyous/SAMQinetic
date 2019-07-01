@Framework @Done
Feature: To Validate Ribbon Object for Home Tab is visible

	
@EnableDisableRibbon
Scenario Outline: Home Ribbon Object Enabled and Disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon           | visibility |
| Copy             | Disabled   |
| Insert           | Enabled    |


