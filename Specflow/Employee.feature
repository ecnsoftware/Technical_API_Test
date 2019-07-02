Feature: Employee



Scenario: Add an Employee
	Given I have the following employees:
	| Id | FullName  | Age | Salary |
	| 1  | Nadensaba | 27  | 400    |
	| 2  | Shaun     | 28  | 200    |
	When I post employee to the api
	Then I delete employees from the database
