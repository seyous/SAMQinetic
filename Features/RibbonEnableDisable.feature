Feature: RibbonEnableDisable

	
@Ribbon
Scenario Outline: Home Ribbon Enabled and Disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon           | visibility |
| Paste            | Disabled   |
| Copy             | Disabled   |
| Undo             | Disabled   |
| Redo             | Disabled   |
| Cut              | Disabled   |
| Delete           | Disabled   |
| Rename           | Disabled   |
| Auto Recalculate | Enabled    |
| Insert           | Enabled    |
| Find             | Enabled    |
| Show Ancestry    | Enabled    |


@Ribbon
Scenario Outline: Layout Ribbon Enabled and Disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon          | visibility |
| Design Explorer | Enabled   |
| Graphics        | Enabled   |
| Message panel   | Enabled   |
| kcl panel       | Enabled   |


@Ribbon
Scenario Outline: Temp Location Enabled and Disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon            | visibility |
| Link to Paramarine| Disabled  |
| Link to Excel     | Disabled  |
| Trace Anscestor   | Enabled   |
| Trace Descendents | Enabled   |


@Ribbon
Scenario Outline: SAM Ribbon enabled and disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon                   | visibility |
| All Scenarios            | Disabled  |
| Additional Scenarios     | Disabled  |
| Random Scenario          | Disabled  |
| Update Results           | Disabled  |


@Ribbon
Scenario Outline: Settings Ribbon enabled and disabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" has a "<visibility>"

Examples: 
| Ribbon         | visibility |
| Text           | Enabled |
| Graphs         | Enabled |
| Excel          | Enabled |
| Messages       | Enabled |
