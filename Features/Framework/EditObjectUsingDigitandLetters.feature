@Framework @Done
Feature: Editing An Object Using Digits and Letters
	
Scenario Outline: Editing object with Valid Object Name
	Given a user opens SAM
	And the user can click on the OK button
	And the user uses "<Test Data>" from "InsertData" xml
	When the user clicks on the Insert button
	And the user clicks on an "Object"
	And the user press function key on the keyboard
	And the user rename the object with "object1234"
	And the user clicks on an "Object"
	And the user click the ok button
	Then the "object1234" should be inserted in the design explorer

	Examples: 
	| Test Data |
	| TestCase1 |
	| TestCase2 |

