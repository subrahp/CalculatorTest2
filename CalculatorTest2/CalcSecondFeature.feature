Feature: CalSpecFeature2
Add two numbers

@SmokeTest
Scenario Outline: Here we do addition of Numbers
Given We have entered <x> into the calculator
And We also have entered <y> into the calculator
When We perform add operation
Then Output of adding <x> and <y> should be <result> on the screen

Scenarios: addition
| x | y | result|
| 1 | 2 | 3|
| 2 | 2 | 4|
| 5 | 4 | 9|
| 100 | 200 | 300|