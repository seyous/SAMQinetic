﻿Feature: Editing An Object Using the Enter Key
	

@editobject
Scenario Outline:Editing object Using Enter Key
Given a user opens SAM
When the warning message is displayed
And the user can click on the OK button
And the user clicks on the Insert button	
And the user clicks on an object
And the user press function key on the keyboard
And the user rename the object with "<Text>"
When the user press the enter key on the keyboard
And the user click the ok button
Then the "<Text>" should be inserted in the design explorer

Examples: 
| Object           | Text                 |
| geom placeholder | gradient placeholder |