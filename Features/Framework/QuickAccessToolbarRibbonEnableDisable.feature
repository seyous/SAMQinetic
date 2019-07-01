@Framework @Done
Feature: To Validate Ribbon Object for Quick Access Toolbar is visible

	
@EnableDisableRibbon
Scenario Outline: Quick Access Toolbar Ribbon Object Enabled and Disabled
Given a user opens SAM
When the user can click on the OK button
Then the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon | visibility |
| Save   | Enabled    |
| Undo   | Disabled    |


