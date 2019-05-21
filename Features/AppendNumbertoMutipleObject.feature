Feature: Append Number to Mutiple Object

		
Background: 
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button		

@mytag
Scenario: Append Number to Multiple object
And the user hover the mouse on an <object>
And the user click on the (+) button 3 times on the pane
And the user click the ok button
Then the 3 <object> should be inserted in the design explorer
