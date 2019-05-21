Feature: Editing An Object
	
Background: 
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button	

@mytag
Scenario: DeSelect object to Rename Click
And the user hover the mouse on an <object>
And the user click on the (pencil) button on the object
And the user rename the object with "text"
And the user press the enter key on the keyboard
And the user click on the (-) button on the object
Then the name of the object is reverted to <object>
And the user click the cancel button


@mytag
Scenario: Editing object Using Pencil Button
And the user hover the mouse on an <object>
And the user click on the (pencil) button on the pane
And the user rename the object with "text"
And the user press the enter key on the keyboard
And the user click the ok button
Then the <object> should be inserted in the design explorer


@mytag
Scenario:Editing object Using the keyboard
And the user hover the mouse on an <object>
And the user press "F2" on the keyboard
And the user rename the object with "text"
And the user press the enter key on the keyboard
And the user click the ok button
Then the <object> should be inserted in the design explorer

@mytag
Scenario:Editing object Using the Enter key
And the user hover the mouse on an <object>
And the user press "F2" on the keyboard
And the user rename the object with "text"
And the user press the enter key on the keyboard
And the user click the ok button
Then the <object> should be inserted in the design explorer

@mytag
Scenario:Editing object Clicking inside the window
And the user hover the mouse on an <object>
And the user press "F2" on the keyboard
And the user rename the object with "text"
And the user click anywhere in the window
And the user click the ok button
Then the <object> should be inserted in the design explorer

@mytag
Scenario:Editing object by pressing the Escape key
And the user hover the mouse on an <object>
And the user press "F2" on the keyboard
And the user rename the object with "text"
And the user press the escape key
Then the name of the object is reverted to <object>
And the user click the cancel button

@mytag
Scenario:Editing object Using Digits and Letters
And the user hover the mouse on an <object>
And the user press "F2" on the keyboard
And the user rename the object with "text123" 
And the user click anywhere in the window
And the user click the ok button
Then the <object> should be inserted in the design explorer


@mytag
Scenario:Editing object Using Special Character
And the user hover the mouse on an <object>
And the user press "F2" on the keyboard
And the user rename the object with "special character"
And the user press the enter key on the keyboard
Then the error message should appear on the button
And the user click the cancel button

