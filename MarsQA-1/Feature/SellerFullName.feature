Feature: SellerFullName

As a seller I would like to update my Full Name.


@Ignore
Scenario Outline: I can update my FullName
	Given I navigate to the Full Name Drop Down button
	When I update my '<FirstName>' and '<LastName>'
	And I save the Full Name
	Then I have updated my '<FullName>' successfully
	Examples:
	| FirstName | LastName  | FullName         |
	| Poppy     | Estrada   | Poppy Estrada    |
	| Cedric    | Dimasuhid | Cedric Dimasuhid |
