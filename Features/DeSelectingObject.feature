Feature: DeSelecting an Object

Background: 
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button	

@mytag
Scenario: Deselecting object On Click
And the user hover the mouse on an object
And the user click on the plus button on the pane
And the user click on the minus button on the pane
Then the object is deselected
And the user click the cancel button


@mytag
Scenario: Deselecting object Using Arrow key
And the user hover the mouse on an object
And the user click on the "Right Arrow" key on the keyboard
Then the object is selected
And the user click on the "left Arrow" key on the keyboard
Then the object is deselected
And the user click the cancel button

@mytag
Scenario:DeSelect an Object Using Spacebar key
And the user hover the mouse on an object
And the user press the spacebar on the keyboard
Then the object is selected
And the user press the spacebar on the keyboard
Then the object is deselected
And the user click the cancel button




