Feature: SellerLanguages

As a seller I would like The languages that I speak be displayed on my Profile page

@tag1
Scenario Outline: Add a new Language on my Profile Page
	Given I navigate to the Languages Section
	When I add a new '<Language>' 
	And I select the '<Level>'
	And I save the new language
	Then The new '<Language>' should be displayed in the Seller Language List
	Examples:
	| Language | Level          |
	| Bisaya   | Fluent         |
	| Tagalog  | Basic          |	

Scenario Outline: Add another Language that already existed on my Profile Page
	Given I navigate to the Languages Section
	When I add an existing language as a new '<Language>' 
	And I select the '<Level>'
	And I save the new language
	Then An error message should be displayed of the duplicate '<Language>'
	Examples:
	| Language | Level          |
	| Bisaya   | Conversational |
	

Scenario Outline: Update an existing Language on my Profile Page
	Given I navigate to the Languages Section
	When I update an existing '<Language>' to a '<New Language>'
	And I update the Level to a '<New Level>' given the current '<Language>'
	And I save the updated '<Language>'
	Then The updated '<New Language>' should be updated successfully
	Examples:
	| Language | New Language | New Level      |
	| Bisaya   |  Tagalog     | Conversational |
	


Scenario: Delete an existing Language on my Profile Page
	Given I navigate to the Languages Section
	When I delete an existing '<Language>'
	Then The existing '<Language>' selected should be deleted successfully
	Examples:
	| Language |
	| Tagalog  |
	
