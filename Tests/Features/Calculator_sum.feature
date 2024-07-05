@Calculator @Sum
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
	| 1		  | +		  | 2	    | =		    | 3		 |
	| 2		  | +		  | 3	    | =		    | 5		 |
	| 3		  | +		  | 4	    | =		    | 7		 |
	| 4		  | +		  | 5	    | =		    | 9		 |
	| 5		  | +		  | 6	    | =		    | 11	 |
	| 6		  | +		  | 7	    | =		    | 13	 |
	| 7		  | +		  | 8	    | =		    | 15	 |
	| 8		  | +		  | 9	    | =		    | 17	 |