Feature: Employee



Scenario: Add an Employee
	Given I have the following employee:
	| FirstName | LastName | DOB        | Gender |
	| Edwin     | Nwosisi  | 1991/08/27 | Male   |
	| Nicola    | Owen     | 1990/06/11 | Female |
	When I post employee to the api
	Then I verify that the request was successful
