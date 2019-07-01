Feature: Selecting Object



@SelectingObject
Scenario Outline:Select an Object On Spacebar key
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button
And the user hover the mouse on an object
And the user press the "spacebar" on the keyboard
Then the object is bold font
And the user click the ok button

Examples: 
| Object |
| Open   |

@SelectingObject
Scenario Outline:Select an Object On Plus key
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button
And the user hover the mouse on an object
And the user press the "plus Key" on the keyboard
Then the object is bold font
And the user click the ok button

Examples: 
| Object |
| Open   |

@SelectingObject
Scenario Outline:Select an Object On Edit
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert buttonAnd the user enter the "text" in the search box
Then the "text" appear on the pane
And the user click the ok button

Examples: 
| Object          |
| Man Placeholder | 

