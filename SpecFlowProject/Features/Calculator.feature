Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the Add result should be 120

@mytag1
Scenario: Sub Two Numbers 
 Given the first number is 10
 And the second number is 5
 When the two numbers are Subtracted
 Then the Sub result should be 5

 @mytag2
Scenario: Multiply Two Numbers 
 Given the first number is 10
 And the second number is 5
 When the two numbers are Multiply
 Then the Mul result should be 50

 @mytag3
 Scenario: Divide Two Numbers 
 Given the first number is 10
 And the second number is 5
 When the two numbers are divided
 Then the Div result should be 2