Feature: To Validate Ribbon Object for File Tab is visible

	
@EnableDisableRibbon
Scenario Outline: File Ribbon Enabled and Disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the File Tab
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon | visibility |
| New    | Enabled    |

