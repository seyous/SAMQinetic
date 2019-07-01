@Framework @Done
Feature: To Validate Ribbon Object for Settings Tab is visible


@EnableDisableRibbon
Scenario Outline: Settings Ribbon enabled and disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the Settings Tab
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon         | visibility |
| Text           | Enabled |
| Graphs         | Enabled |

