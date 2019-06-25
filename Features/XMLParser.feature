﻿Feature: XMLParser


@mytag
Scenario Outline: XML Parser
	#Given a user opens SAM
	#Given the user uses "InsertData" xml
	Given the user uses "<Test Data>" from "InsertData" xml
	When the user can click on the OK button
	When the user clicks on the Insert button
	And the user clicks on an "Object"
	And the user click on the pencil button on the object
	And the user rename the object with "Text"
	And the user press the enter key on the keyboard
	And the user click on the play button on the object
	And the user closes the insert window
	Then the object should be inserted in the design explorer

	Examples: 
	| Test Data | Object           | Text              |
	| TestCase1 | geom placeholder | b1, b2, b3, b4    |
	| TestCase2 | geom placeholder | geom placeholder1 |