@Framework @Done
Feature: Editing Object Using Special Character

@editobject
Scenario Outline:Editing object With invalid Object Name
	Given a user opens SAM
	And the user can click on the OK button
	And   the user uses "<Test Data>" from "InsertData" xml
	When the user clicks on the Insert button
	And the user clicks on an "Object"
	And the user press function key on the keyboard
	And the user rename the object with "@#$^1234"
	And the user press the enter key on the keyboard
	And the user can click on the OK button
	Then the "Invalid object name" should appear on the button


Examples: 
| Test Data | 
| TestCase1 | 
| TestCase2 |
