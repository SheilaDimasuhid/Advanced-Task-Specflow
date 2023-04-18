Feature: SellerEducation

As a seller I would like my list of Educational Attainment be displayed on my Profile page

@Ignore
Scenario: Add a new Education on my Profile Page
	Given I navigate to the Education Section
	When I add new '<Education>', '<University>', '<Degree>'
	And I  select the '<Country>', '<Title>', '<Degree>', '<YearGraduated>'
	And I save the changes
	Then The new Education should be displayed in the Seller Education List

@Ignore
Scenario: Update an existing Education on my Profile Page
	Given I navigate to the Education Section
	When I update an existing '<Education>', '<University>', '<Degree>'
	And I  select the '<Country>', '<Title>', '<Degree>', '<YearGraduated>'
	And I save the changes
	Then The existing Education should be updated successfully

@Ignore
Scenario: Delete an existing Education on my Profile Page
	Given I navigate to the Education Section
	When I delete an existing Education
	Then The existing Education should be deleted successfully