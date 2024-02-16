Feature: CampaignCreation
	User is able to create a campaign

Scenario: Successful campaign creation
	Given I login
	When I fill out the form with valid details
	And I submit the form
	Then I should see a confirmation of campaign creation