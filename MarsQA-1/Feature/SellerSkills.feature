Feature: SellerSkills

As a seller I would like my Skills to be displayed on my Profile page

@Ignore
Scenario: Add a new Skill on my Profile Page
	Given I navigate to the Skills Section
	When I add new '<Skill>' 
	And I select the Level
	And I save the changes
	Then The new Skill should be displayed in the Seller Skill List

@Ignore
Scenario: Update an existing Skill on my Profile Page
	Given I navigate to the Skills Section
	When I edit an existing Skill
	And I save the changes
	Then The existing Skill should be updated successfully

@Ignore
Scenario: Delete an existing Skill on my Profile Page
	Given I navigate to the Skills Section
	When I delete an existing Skill
	Then The existing Skill should be deleted successfully