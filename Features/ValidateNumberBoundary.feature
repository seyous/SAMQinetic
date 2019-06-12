Feature: ValidateNumberBoundary
	
	
@boundaryValue
Scenario Outline: Settings Ribbon for boundary values
Given a user opens SAM
When the warning message is displayed
Then the user can click on the OK button
And the ribbon "<Ribbon>" value is '<minimumvalue>' and  '<maximumvalue>' 

Examples: 
| Ribbon                     | minimumvalue | maximumvalue |
| Max. number of columns     | 4          | 200          |
| Prompt user if rows exceed | 0           | 1000000      |
| Max. number of messages    | 0           | 10000        |
| Min. width                 | 150         | 500          |
| Max. width                 | 300         | 1000         |

