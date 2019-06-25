Feature: Validate Number Boundary for Settings Menu
	
	
@RibbonboundaryValue
Scenario: Validate Minimum Values for Column TextBox
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user click the Settings Tab
And the user enters 4 into the textbox
And the user press the enter key on the keyboard
Then the number changes to 6 in the textbox
 


 @RibbonboundaryValue
Scenario: Validate Maximum Values for Column TextBox
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button

And the user enters 201 into the textbox
And the user press the enter key on the keyboard
Then the number changes to 200 in the textbox