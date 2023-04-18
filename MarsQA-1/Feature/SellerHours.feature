Feature: SellerHours

As a seller I would like to add or update my Hours of Service (Less than 30hours/week,
	More than 30hours/week, or As needed)

@Ignore
Scenario: Add or update my Hours of Service
	Given I navigate to the add Hours section
	When I select my Hours
	Then The Hours selected should be displayed on my Profile page