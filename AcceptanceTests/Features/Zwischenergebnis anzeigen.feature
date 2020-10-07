Feature: Zwischenergebnis anzeigen

Scenario: Zwischenergebnisse anzeigen
	When ich den Ball einmal schlage
	And ich Zwischenergebnis aufrufe
	Then zeigt der NerdGolfTracker als Zwischenergebnis 1 Schlag
	
	When ich den Ball noch einmal schlage
	And ich Zwischenergebnis aufrufe
	Then zeigt er als Zwischenergebnis 2 Schlaege

	When ich zum naechsten Loch gehe
	And ich Zwischenergebnis aufrufe
	Then zeigt er als Zwischenergebnis 2 Schlaege

	When ich den Ball noch einmal schlage
	And ich Zwischenergebnis aufrufe
	Then zeigt er als Zwischenergebnis 3 Schlaege

