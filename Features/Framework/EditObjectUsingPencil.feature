@Framework @Done
Feature: Edit Object Using Pencil
	

@editobject
Scenario Outline: Editing object Using Pencil Button
	Given a user opens SAM
	And the user can click on the OK button
	And  the user uses "<Test Data>" from "InsertData" xml
	When the user clicks on the Insert button
	And the user clicks on an "Object"
	And the user click on the pencil button on the object
	And the user rename the object with "geom placeholder1"
	And the user press the enter key on the keyboard
	And the user click on the play button on the object
	And the user closes the insert window
	Then the object should be inserted in the design explorer

Examples: 
| Test Data | 
| TestCase1 | 
| TestCase2 |

