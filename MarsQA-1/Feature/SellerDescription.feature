Feature: SellerDescription

As a seller I would like to add or update my Description

@Ignore
Scenario: I update the Seller Description
	Given I navigate to the seller section
	When I add or update the seller description with a maximum of 600 characters
	Then The description should be displayed in my Profile page
