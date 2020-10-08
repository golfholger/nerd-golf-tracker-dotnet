Feature: Zwischenergebnis anzeigen

Scenario: Zwischenergebnisse anzeigen
	When ich den Ball einmal schlage
	And ich Zwischenergebnis aufrufe
	Then zeigt der NerdGolfTracker als Zwischenergebnis 1 Schlag
	
Scenario: Zweimal schlagen und Zwischenergebnis anzeigen
	When ich den Ball einmal schlage
	And ich den Ball noch einmal schlage
	And ich Zwischenergebnis aufrufe
	Then zeigt der NerdGolfTracker als Zwischenergebnis 2 Schlaege

Scenario: Schlagen, zum naechsten Loch gehen und Zwischenergebnis anzeigen
	When ich den Ball einmal schlage
	And ich zum naechsten Loch gehe
	And ich Zwischenergebnis aufrufe
	Then zeigt der NerdGolfTracker als Zwischenergebnis 1 Schlag