Feature: Cancel Button Available
	In order to Validate that the cancel button is
	Available and can be closed by clicking with mouse and using the Esc key 
	on the Keyboard

	Background: 
	Given a user opens SAM
	When the warning message is displayed
	Then the user can click on the OK button
	And the user clicks on the Insert button

@mytag
Scenario: Cancel Button Available
And the Cancel button is avaialable
And the user confirms the cancel button is available

@mytag
Scenario: Cancel Button Closes On Escape
And the Cancel button is available
And the use press "Esc" key on the keyboard
Then the insert dialog closes

@mytag
Scenario:Cancel Button Closes On Click
And the Cancel button is available
And the user click on the Cancel button
Then the insert dialog closes

