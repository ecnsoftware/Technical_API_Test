Feature: Employee



Scenario: Add an Employee
	Given I have the following employee:
	| Id | FullName      | Age | Salary |
	| 1  | Edwin Nwosisi | 27  | 400    |
	| 2  | Nicola Owen   | 28  | 200    |
	When I post employee to the api
	Then I verify that the request was successful
