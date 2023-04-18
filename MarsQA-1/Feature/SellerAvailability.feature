Feature: SellerAvailability

As a seller I would like to add or update my availability (Part Time or Full Time)

@Ignore
Scenario: Add or update my availability
	Given I navigate to the add availability section
	When I select my availability
	Then The selected availability should be displayed on my Profile page
