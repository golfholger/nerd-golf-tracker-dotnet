Feature: Undo

Scenario: Schlaege rueckgaengig machen
	When ich den Ball einmal schlage
	And ich den Ball noch einmal schlage
	Then zaehlt der NerdGolfTracker 2 Schlaege
	When ich den Schlag rueckgaengig mache
	Then zaehlt der NerdGolfTracker 1 Schlag