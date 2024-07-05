@Calculator @Substance
Feature: Validate basic operations like substance two numbers

Calculator: Simple Tests for Windows Calculator

Scenario Outline: Substance two numbers
	Given Calculator starts
	When User selects number <number1>
	And User press operator <operator1>
	And User selects number <number2>
	And User press operator <operator2>
	Then Result should be <result>
Examples:
	| number1 | operator1 | number2 | operator2 | result |
	| 9		  | -		  | 1	    | =		    | 8		 |
	| 8		  | -		  | 2	    | =		    | 6		 |
	| 7		  | -		  | 3	    | =		    | 4		 |
	| 6		  | -		  | 4	    | =		    | 2		 |
	| 5		  | -		  | 5	    | =		    | 0		 |
	| 4		  | -		  | 6	    | =		    | -2	 |
	| 3		  | -		  | 7	    | =		    | -4	 |
	| 2		  | -		  | 8	    | =		    | -6	 |
	| 1		  | -		  | 9	    | =		    | -8	 |

Examples:
	| number1 | operator1 | number2 | operator2 | result |
	| 9		  | -		  | 5	    | =		    | 4		 |