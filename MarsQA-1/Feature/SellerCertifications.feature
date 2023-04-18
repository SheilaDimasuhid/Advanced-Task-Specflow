Feature: SellerCertifications

As a seller I would like the Certificates that I obtained be displayed on my Profile page

@Ignore
Scenario: Add a new Certification on my Profile Page
	Given I navigate to the Certifications Section
	When I add new '<Certificate>' , '<CertifiedFrom>'
	And I select the '<Year>' certified
	And I save the changes
	Then The new Certificate should be displayed in the Seller Education List

@Ignore
Scenario: Update an existing Certification on my Profile Page
	Given I navigate to the Certifications Section
	When I update an existing '<Certificate>' , '<CertifiedFrom>'
	And I select the '<Year>' certified
	And I save the changes
	Then The existing Certificate should be updated successfully

@Ignore
Scenario: Delete an existing Certification on my Profile Page
	Given I navigate to the Certifications Section
	When I delete an existing Certificate
	Then The existing Certificate should be deleted successfully


