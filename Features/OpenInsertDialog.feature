Feature: OpenInsertDialog
	In order to Open the Insert
	Dialog Box and I click on the Ribbon


@mytag
Scenario: Click on InsertRibbon
	Given a user opens SAM
	When the warning message is displayed
	Then the user can click on the OK button
	And the user clicks on the Insert button
