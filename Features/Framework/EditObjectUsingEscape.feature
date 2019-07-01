@Framework @Done
Feature: Edit Object by Pressing the Escape Key 

@editobject
Scenario Outline:Editing object Using the Escape Key
	Given a user opens SAM
	And the user can click on the OK button
	And the user uses "<Test Data>" from "InsertData" xml
	When the user clicks on the Insert button
	And the user clicks on an "Object"
	And the user press function key on the keyboard
	And the user rename the object with "text1234"
	And the user press the escape key
	Then the object is reverted to "geom placeholder"

Examples: 
| Test Data | 
| TestCase1 | 
| TestCase2 |