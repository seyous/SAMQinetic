Feature: Insertable Object Description 
		Grouping object folder
		And Expanding the folder structure using leftRight arrow keys 
	

@mytag
Scenario: Insertable Object Description
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the user clicks on the Insert button
And the user click an object 
And the object will have the following "description"
And the user click the ok button
And the object should be inserted in the design explorer

@mytag
Scenario: Folder Grouping of object
And the user clicks on the Insert button
And the user double click an object placeholder
And the user click an object 
And the user click the ok button
And the object should be inserted in the design explorer
Then the structure is one level deep

@mytag
Scenario:Folder Expand using leftRight Arrow key
And the press the "left arrow" key on the keyboard
And the user press the "right arrow" key on the keyboard
Then the user folder item collapse on the design explorer
