@Calculator @Add
Feature: Validate basic operations like add two numbers

Calculator: Simple Tests for Windows Calculator

Scenario Outline: Add two numbers
	Given Calculator starts
	When User selects number <number1>
	And User press operator <operator1>
	And User selects number <number2>
	And User press operator <operator2>
	Then Result should be <result>
Examples:
	| number1 | operator1 | number2 | operator2 | result |
	| 0		  | +		  | 1	    | =		    | 1		 |
	| 1		  | +		  | 1	    | =		    | 2		 |
	| 0		  | +		  | 0	    | =		    | 0		 |