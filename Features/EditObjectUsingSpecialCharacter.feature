Feature: Editing Object Using Special Character
	
	

@editobject
Scenario Outline:Editing object Using Special Character
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button	
When the user clicks on an "<Object>"
And the user press function key on the keyboard
And the user rename the object with "<Text>"
When the user clicks on an "<Object>"
Then the "Invalid object name" should appear on the button


Examples: 
| Object           | Text     |
| geom placeholder | @#$^1234 |
