Feature: Confirm Object is selected On Mouse Click


@SelectingObject
Scenario Outline: Select an Object On Click
Given a user opens SAM
When the warning message is displayed
And the user can click on the OK button
And the user clicks on the Insert button
And the user hover the mouse and click on an "<Object>"
Then the user confirms the object is selected in bold font


Examples: 
| Object |
| man placeholder  |





