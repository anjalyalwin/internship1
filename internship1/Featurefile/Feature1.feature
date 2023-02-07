Feature: Seller Added Profile Details

As a seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.


Scenario: Add the profile details
	Given I logged into localhost successfully
	When I navigate to Profile Page
	And I added the profile details
	Then The profile details added successfully

Scenario Outline: Add the language details
Given I logged into localhost successfully
When I navigate to Profile Page
And I updated '<describtion>' details
Then The details added successfully '<describtion>'

Examples: 
| describtion   |
| language      |
| Skills        |
| certification |
| Education     |