Feature: Cancel Button Available
	In order test the Validate that the cancel button is
	Available and can be closed clicking with mouse and using the Esc key 
	on the Keyboard

	Background: 
	Given a user opens SAM
	When the warning message is displayed
	Then the user can click on the OK button
	And the user clicks on the Insert button

@mytag
Scenario: CancelButtonAvailable
And the Cancel button is avaialable
And the user confirms the cancel button is available

@mytag
Scenario: CancelButtonClosesOnEscape
And the Cancel button is available
And the use press "Esc" key on the keyboard
Then the insert dialog closes

@mytag
Scenario:CancelButtonClosesOnClick
And the Cancel button is available
And the user click on the Cancel button
Then the insert dialog closes

