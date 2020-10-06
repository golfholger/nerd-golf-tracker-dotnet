Feature: Hilfe

Scenario: Gut formatierte Hilfe
	When ich die Hilfe aufrufe
	Then zeigt der NerdGolfTracker die Hilfe zu jedem Kommando in einer separaten Zeile an

Scenario: Allgemeine Hilfe
	When ich die Hilfe aufrufe
	Then zeigt der NerdGolfTracker seine Benutzung an

Scenario Outline: Hilfe zu Kommandos
	When ich die Hilfe aufrufe
	Then erklärt der NerdGolfTracker das Kommando "<kommando>"

	Examples: 
	| kommando       |
	| Hilfe          |
	| Schlage Ball   |
	| Naechstes Loch |