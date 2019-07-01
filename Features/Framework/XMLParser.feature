@Framework @Done
Feature: XMLParser


@mytag
Scenario Outline: XML Parser
	Given a user opens SAM
	And the user can click on the OK button
	And the user uses "<Test Data>" from "InsertData" xml
	When the user clicks on the Insert button
	When the user clicks on an "Object"
	And the user click on the pencil button on the object
	And the user rename the object with "Text"
	And the user press the enter key on the keyboard
	And the user click on the play button on the object

	Examples: 
	| Test Data |
	| TestCase1 |
	| TestCase2 |