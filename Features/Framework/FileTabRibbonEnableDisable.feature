@Framework @Done
Feature: To Validate Ribbon Object for File Tab is visible

	
@EnableDisableRibbon
Scenario Outline: File Ribbon Enabled and Disabled
Given a user opens SAM
And the user can click on the OK button  
When the user click the File Tab
Then the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon | visibility |
| New    | Enabled    |
