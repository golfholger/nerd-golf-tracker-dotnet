Feature: Zwischenergebnis

Scenario: Zwischenergebnis anzeigen drei Schlaege
	Given ich habe den Ball einmal geschlagen
	When ich zum naechsten Loch gehe
	And ich den Ball noch einmal schlage
	And ich den Ball noch einmal schlage
	And Zwischenergebnis aufrufe
	Then zeigt der NerdGolfTracker insgesamt 3 Schlaege

Scenario: Zwischenergebnis anzeigen einen Schlag
	Given ich habe den Ball einmal geschlagen
	When Zwischenergebnis aufrufe
	Then zeigt der NerdGolfTracker insgesamt 1 Schlag

Scenario: Zwischenergebnis anzeigen keinen Schlag
	When Zwischenergebnis aufrufe
	Then zeigt der NerdGolfTracker insgesamt 0 Schlaege