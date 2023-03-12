Feature: Equipments
	Tests for the equipments	

@mytag
Scenario: Add a equipment
	Given there is some equipment with the following details
		| name         | description            | price |
		| 5kg dumbbell | dumbbell for beginners | 15.99 |
	When I get the equipment list
	Then I can find my equipment
