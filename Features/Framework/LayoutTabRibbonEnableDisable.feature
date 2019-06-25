Feature: To Validate Ribbon Object for Layout Tab is visible

	
@EnableDisableRibbon
Scenario Outline: Layout Ribbon Enabled and Disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the layout Tab
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon          | visibility |
| Design Explorer | Enabled   |
| Graphics        | Enabled   |

