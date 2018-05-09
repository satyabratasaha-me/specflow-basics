Feature: SimpleCalculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Multiply numbers 
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press multiply
	Then the result should be 3500 on the screen

Scenario Outline: Add multiple numbers with parametriazation
	Given I have entered <num1> into the calculator
	And I have entered <num2> into the calculator
	When I press add
	Then the result should be <expected_result> on the screen

Examples: 
	| num1 | num2 | expected_result |
	| 1    | 2    | 3               |
	| 2    | 2    | 4               |
	| 3    | 4    | 7               |

Scenario: Add numbers with datatable
	Given I have a list of numbers
		| numbers |
		| 1       |
		| 2       |
		| 3       |
	When I press add
	Then the result should be 6 on the screen












