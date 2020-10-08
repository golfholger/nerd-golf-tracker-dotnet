Feature: Ball schlagen

Scenario: Einen Schlag zaehlen
	When ich den Ball einmal schlage
	Then zaehlt der NerdGolfTracker 1 Schlag

Scenario: Einen zweiten Schlag zaehlen
	Given ich habe den Ball bereits einmal geschlagen
	When ich den Ball noch einmal schlage
	Then zaehlt der NerdGolfTracker 2 Schlaege

Scenario: Loch anzeigen
	When ich den Ball einmal schlage
	Then zaehlt er die Schlaege auf dem 1. Loch
