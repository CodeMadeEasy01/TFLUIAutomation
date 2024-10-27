Feature: Tfl journey planner
 
@TFLUI
Scenario: Plan a valid journey from leicester sqaure to Covent Garden
	Given I naviagate to the TFL journey planner page
	When  I enter "Lecicester square underground station" as the start point 
	And   I  select "Covent Garden Underground Stattion" as the destination 
	And   I click on Plan my journey button
	Then  I  should see valid walking and cycling times 

Scenario: Edit preference to select routues with least walking 
  Given   I naviagate to the TFL journey planner page
	When  I enter "Lecicester square underground station" as the start point 
	And   I  select "Covent Garden Underground Stattion" as the destination 
	And   I click on Plan my journey button
	When  I click on Edit Preference button
	And   I select least walking
	And   I update the journey 
	Then  I should see updated journey time  

Scenario: View details for Covent Garden Station
    Given I naviagate to the TFL journey planner page
	When  I enter "Lecicester square underground station" as the start point 
	And   I  select "Covent Garden Underground Stattion" as the destination 
	And   I click on Plan my journey button
	When  I click on Edit Preference button
	And   I select a routes with least walking
	And   I click on update journey
	When  I click on View Details button
	Then  I should see complete access information for Covent Garden Underground Station 

Scenario: Invalid journey planning  
    Given I navigate to the TFL Journey Planner page 
	When  I enter "Invalid Location" as the start point
	And   I enter "Another Invalid Location " as the destination
	And   I click on Plan my Joruney button
	Then  I should see no results available

Scenario: No locations entered for a journey planning 
    Given I naviagate to the TFL Joruney Planner page 
	When  I click on "Plan my Joruney" without entering any locations
	Then  I should see an error message indicating no locations entered 

	
