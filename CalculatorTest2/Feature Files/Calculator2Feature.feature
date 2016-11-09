Feature: CalSpecFeature
Adding the given two numbers

@SmokeTest
Scenario Outline: Addition of Numbers
Given I have entered <x> into the calculator
And Also have entered <y> into the calculator
When I press add
Then the result of adding <x> and <y> should be <result> on the screen

Scenarios: addition 
| x | y | result|
| 1 | 2 | 3|
| 2 | 2 | 4|
| 5 | 4 | 9|
| 100 | 200 | 300|