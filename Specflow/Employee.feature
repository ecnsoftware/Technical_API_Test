Feature: Employee



Scenario: Add an Employee
	Given I have the following employee:
	| Id | FullName | Age | Salary |
	| 1  | Georgee   | 27  | 400    |
	| 2  | Nicola   | 28  | 200    |
	When I post employee to the api
	Then I verify that the request was successful
