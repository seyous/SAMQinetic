Feature:To Validate Appending Number to Mutiple Objects
And Object Name must be unique for Sibling Objects
Parent Object name must not start with digit

		
Background: 
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button		

@mytag
Scenario: Append Number to Multiple object
And the user hover the mouse on an object
And the user click on the plus button 3 times on the pane
And the user click the ok button
Then the object should be inserted in the design explorer

@mytag
Scenario: Object name must be unique for sibling objects
And the user hover the mouse on an object
And the user click on the parent object
And the user click on the play button
Then the a new dialog appears
And the user  double click the object
And the user click on the child object
And the user click the ok button
Then the object should be inserted in the design explorer

@mytag
Scenario: Parent object name must not start with digit
And the user hover the mouse on an object
And the user press "F2" on the keyboard
And the user rename the object with "123text" 
And the user click anywhere in the window
And the user click the ok button
Then the error message should appear on the button