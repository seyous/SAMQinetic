@Framework @Done
Feature: To Validate Ribbon Object for Layout Tab is visible

	
@EnableDisableRibbon
Scenario Outline: Layout Ribbon Enabled and Disabled
	Given a user opens SAM
	And the user can click on the OK button
	When the user click the layout Tab
	Then the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon          | visibility |
| Design \n Explorer | Enabled   |
| Graphics        | Enabled   |

