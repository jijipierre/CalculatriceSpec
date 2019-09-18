Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers, delete, multiply and divide two numbers
	Given I have entered 80 into the calculator
	And I have entered Also 40 into the calculator
	When I press add
	Then the result should be 120 on the screen
	When I press delete
	Then the result of delete should be 40 into the calculator
	When I press multiply
	Then the result of multiply should be 3200 into the calculator
	When I press divide
	Then the result  of divieshould be 2 into the calculator
