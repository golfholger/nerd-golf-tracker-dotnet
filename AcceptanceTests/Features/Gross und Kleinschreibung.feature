Feature: Gross und Kleinschreibung

Scenario: Rufe Hilfe in Kleinschreibung auf
	When ich "hilfe" eingebe
	Then zeigt der NerdGolfTracker seine Benutzung an

Scenario: Rufe Hilfe in zufaelliger Schreibweise auf
	When ich "hIlFE" eingebe
	Then zeigt der NerdGolfTracker seine Benutzung an
