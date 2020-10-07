Feature: Kurzbefehl
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Kurzbefehl Ball schlagen
	When ich den Kurzbefehl "S" verwende
	Then zaehlt der NerdGolfTracker 1 Schlag

Scenario: Kurzbefehl Loch wechseln
	When ich den Kurzbefehl "N" verwende
	Then zaehlt der NerdGolfTracker die Schlaege auf dem 2. Loch

Scenario: Kurzbefehl Hilfe
	When ich den Kurzbefehl "H" verwende
	Then zeigt der NerdGolfTracker seine Benutzung an