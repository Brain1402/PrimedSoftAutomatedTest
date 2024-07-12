Feature: PrimedsoftHomepage

As a usser
I want to navigate to Primedsoft Homepage so i can view the home page


Background: navigation step
Given user navigate to primedsoft website "https://primedsoft.com/"
When user clicks on Register
And user clicks on Data analysis

@tag1 
Scenario: To verify user can view primedsoft homepage
	Then I should see the page

@tag2	
Scenario: Price Functional Button
	Then I should be able to see the amount needed for the course
	And I click on the Amount Button
	Then I should be redirected to Register course

@tag3
Scenario: verify course description
	When user click on Course Description
	Then I should see the Course Description

@tag4
Scenario: verify course outline
	When user click on Course Outline
	Then I should see the Course Outline
