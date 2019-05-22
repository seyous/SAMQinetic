Feature: Selecting Object

Background: 
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button	

@mytag
Scenario: Hovering mouse on an Object
And the user hover the mouse on an object
Then the user confirms the displayed buttons

@mytag
Scenario: Select an Object On Click
And the user click the object
Then the object is bold font
And the user click the ok button

@mytag
Scenario:Select an Object On Spacebar key
And the user hover the mouse on an object
And the user press the "spacebar" on the keyboard
Then the object is bold font
And the user click the ok button

@mytag
Scenario:Select an Object On Plus key
And the user hover the mouse on an object
And the user press the "plus Key" on the keyboard
Then the object is bold font
And the user click the ok button

@mytag
Scenario:Select an Object On Edit
And the user enter the "text" in the search box
Then the "text" appear on the pane
And the user click the ok button

