Feature: OKbuttonEnabled
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


	Background: 
	Given a user opens SAM
	When the warning message is displayed
	Then the user can click on the OK button
	And the user clicks on the Insert button

@mytag
Scenario: OK Button Enabled
	When the user click on the list of <objects>
	
	| objects 1 | objects 2 | objects 3 | objects 4 |
	
	And the Ok button is enabled


	@mytag
	Scenario: OK Buttton insert Objects
	When the user click on the list of <objects>
	
	| objects 1 | objects 2 | objects 3 | objects 4 |
	
	And the Ok button is enabled
	And the user click the ok button
    Then the <object> should be inserted in the design explorer
