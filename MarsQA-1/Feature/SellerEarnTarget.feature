Feature: SellerEarnTarget

As a seller I would like to add or update my Target Earnings per month 
	(Less than $500 per month, Between $500 to $1000 per month, or More than $1000 per month)

@Ignore
Scenario: Add or update my Target Earnings
	Given I navigate to the add Earn Target section
	When I select my Earn Target
	Then The selected Earn Target should be displayed on my Profile page