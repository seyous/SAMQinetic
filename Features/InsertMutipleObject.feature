Feature: Inserting Mutiple Object
		
Background: 
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button	

@mytag
Scenario:Insert mutiple object
And the user hover the mouse on an <object>
And the user click on the (pencil) button on the object
And the user type b1, b2, b3, b4
And the user press the enter key on the keyboard
And the user click the ok button
Then the <object> should be inserted in the design explorer


@mytag
Scenario:Insert mutiple object Using Colon
And the user hover the mouse on an <object>
And the user click on the (pencil) button on the object
And the user type b1;b2;b3;b4
And the user press the enter key on the keyboard
And the user click the ok button
Then the <object> should be inserted in the design explorer

@mytag
Scenario: Insert mutiple object using plus button
And the user hover the mouse on an <object>
And the user click on the (+) button 3 times on the pane
And the user click the ok button
Then the <object> should be inserted in the design explorer


@mytag
Scenario:Insert object Using the Right Arrow key on Keyboard
And the user hover the mouse on an <object>
And the user click on the "Right Arrow" key twice on the keyboard
And the user click the ok button
Then the <object> should be inserted in the design explorer

@mytag
Scenario:Insert object Using the plus button on the pane
And the user hover the mouse on an <object>
And the user click on the (+) button 3 times on the pane
Then  the user sees 3 object
And the user click the ok button
Then the <object> should be inserted in the design explorer





