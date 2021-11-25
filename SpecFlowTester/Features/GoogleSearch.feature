Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@SearchingSomething
Scenario: Search something
	Given Given I Navigate to "http://google.pl"
	When I enter searched frase
	And Press search button
	Then I find Serched element