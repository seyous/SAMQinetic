Feature: Editing An Object Using Digits and Letters
	

@editobject
Scenario Outline:Editing object with Valid Object Name
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button	
When the user clicks on an "<Object>"
And the user press function key on the keyboard
And the user rename the object with "<Valid Object Name>"
When the user clicks on an "<Object>"
And the user click the ok button
Then the "<Text>" should be inserted in the design explorer

Examples: 
| Object           | Valid Object Name        |
| geom placeholder | object1234  |

