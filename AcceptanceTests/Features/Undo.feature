Feature: Undo

Scenario: Schlaege rueckgaengig machen
	When ich den Ball einmal schlage
	And ich den Ball noch einmal schlage
	And ich den Schlag rueckgaengig mache
	Then zaehlt der NerdGolfTracker 1 Schlag

	When ich den Schlag rueckgaengig mache
	Then zaehlt der NerdGolfTracker 0 Schlaege