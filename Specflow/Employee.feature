Feature: Employee



Scenario: Add Employees
	Given I have the following employees:
	| Id  | FullName | Age | Salary |
	| 106 | Jaykee   | 27  | 400    |
	| 107 | Lucky    | 28  | 200    |
	When I post employee to the api
	Then I verify that the request was successful
