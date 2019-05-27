Feature: RibbonValidations
	
@Ribbon
Scenario Outline: Home Ribbon is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
|Paste |
|Undo |
|Redo |
|Cut |
|Delete |
|Rename |


Scenario Outline: Home Ribbon AutoRecal is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Auto Recalculate       |


@Ribbon
Scenario Outline: Home Ribbon Block Action is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Insert       |
|Find |
|Properties |
|Tabular View |
|Object Setup |
|Move Up |
|Move Down |
|Force Recalculate|
|Protect |
|Units |
|Show Ancestry |
|Level |



@Ribbon
Scenario Outline: Home Ribbon Block Macro is Displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" is displayed

Examples: 
| Ribbon |
| Macro       |