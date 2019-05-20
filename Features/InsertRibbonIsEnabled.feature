Feature: InsertRibbonIsEnabled
	In order to validate that the insert Ribbon
	Is enabled

@mytag
Scenario:  Insert Ribbon Enabled
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button 
And the user place the mouse over the insert button
Then the ribbon should be enabled
And the user press the "insert key" to open insert button

