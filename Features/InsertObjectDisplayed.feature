Feature: Inserting Object Is Displayed

@insert
Scenario Outline:Insert placeholder objects displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button
And the insert object "<Object>" is displayed

Examples: 
| Object           |
| geom placeholder |
| man placeholder |
| military placeholder |
| seakeeping placeholder |
| stub placeholder |
| structure placeholder |
| struct placeholder old |



@insert
Scenario Outline:Insert Output objects displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button
And the insert object "<Object>" is displayed

Examples: 
| Object           |
| graph diagram |
| report |
| report CSS definition |
| report deckplan |
| report deckplan review |
| report global settinngs|
| report schema |
| view 2D |



@insert
Scenario Outline:Insert Miscellaneous objects displayed
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button
And the insert object "<Object>" is displayed

Examples: 
| Object                  |
| bitmap from file        |
| report                  |
| design comparer         |
| display capture         |
| display case locker     |
| drawing                 |
| earth axes workbook     |
| excel workbook          |
| fly through             |
| front panel             |
| goal seek               |
| graph                   |
| graph 2Y                |
| graph polar             |
| spreadsheet             |
| switch object           |
| table custom user input |
| tag                     |
| texture map             |
| var                     |
| weight                  |
| weight distribution     |
| weight linear           |
| weight linear start end |
| weight summary          |


