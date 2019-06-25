Feature: Edit Object by Pressing the Escape Key 
	
	

@editobject
Scenario:Editing object Using the Escape Key
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button	
When the user clicks on an "geom placeholder"
And the user press function key on the keyboard
And the user rename the object with "text1234"
And the user press the escape key
Then the object is reverted to "geom placeholder"

