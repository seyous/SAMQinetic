Feature: Validating the OK button Enabled
Using the Ok button and the Enter button to Insert object
	


	Background: 
	Given a user opens SAM
	When the warning message is displayed
	Then the user can click on the OK button
	And the user clicks on the Insert button

@mytag
Scenario: OK Button Enabled
	Given the user click on 4 parent objects
	Then the Ok button is enabled
	And the user click the ok button


	@mytag
	Scenario: OK Buttton insert Objects
	Given the user click on 4 parent objects
	Then the Ok button is enabled
	And the user click the ok button
    Then the object should be inserted in the design explorer

	@mytag
	Scenario: Enter Key on Keyboard insert Objects
	Given the user click on 4 parent objects	
	Then the Ok button is enabled
	And the user press the enter key on the keyboard
    Then the object should be inserted in the design explorer
