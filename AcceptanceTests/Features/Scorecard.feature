Feature: Scorecard anzeige

@ignore
Scenario: Spielt zwei Löcher
When ich den Ball einmal schlage
When ich zum naechsten Loch gehe
When ich den Ball 3 mal schlage
And ich eingebe "Scorecard"
Then sehe ich "Loch 1:1, Loch 2:3"

