Feature: Tester

@Searchbar
Scenario: Open homepage
	Given I open homepage "http://google.pl"
	Then Homepage should appear

@SearchingSomething
Scenario:
	Given Given I open homepage "http://google.pl"
	When I enter searched frase
	And Press search button
	Then I find Serched element
