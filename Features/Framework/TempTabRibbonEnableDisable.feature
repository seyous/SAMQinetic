Feature: To Validate Ribbon Object for TempLocation Tab is visible

	
	
@EnableDisableRibbon
Scenario Outline: Temp Location Enabled and Disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click on the Temp Location Tab
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon            | visibility |
| Link to Paramarine| Disabled  |
| Trace Anscestor   | Enabled   |
