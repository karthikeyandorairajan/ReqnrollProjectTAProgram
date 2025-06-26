
@regression @bvt
Feature: Calculator Feature

Simple calculator for calculating two numbers

@addition
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@subtraction
Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 30
	When the two numbers are subtracted
	Then the result should be 20

@multiplication
Scenario: Multiply two numbers
	Given the first number is 40
	And the second number is 70
	When the two numbers are multiplied
	Then the result should be 2800

@division
Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 2
	When the two numbers are divided
	Then the result should be 25