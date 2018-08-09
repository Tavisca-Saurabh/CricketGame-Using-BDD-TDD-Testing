Feature: TeamPlayerScore
	In order to enjoy a game of cricket between two players
	As an audience
	I want to see the result of the match

@mytag
Scenario: Players Score is zero when game starts
	When Players has started a game of cricket
	Then the players score should be 0

Scenario: Player 1 scores runs
	Given Player 1 has started a game of cricket  
	When Player 1 scores 4 runs
	Then Player 1 has scored 4

Scenario: Player 2 scores runs
	Given Player 2 has started a game of cricket
	When Player 2 scores 6 runs
	Then Player 2 has scored 6

Scenario: Player one gets out after scoring some runs
	Given Player 1 has started a game of cricket
	Given Player 1 scores 3 runs
	Given Player 1 gets out
	When Player 1 scores 5 runs
	Then Player 1 has scored 3

Scenario: Player 2 gets out after scoring some runs
	Given Player 2 has started a game of cricket
	Given Player 2 scores 3 runs
	Given Player 2 scores 5 runs
	Given Player 2 gets out
	When Player 2 scores 1 runs
	Then Player 2 has scored 8

Scenario: Both the players get out and the result is decared
	Given Player 2 has started a game of cricket
	Given Player 2 scores 1 runs
	Given Player 2 scores 2 runs
	Given Player 2 gets out
	Given Player 1 has started a game of cricket
	Given Player 1 scores 2 runs
	Given Player 1 gets out
	When Both get out
	Then Declare the result Player 2 wins with more runs

Scenario: Both score the same runs and result is declared
	Given Player 2 has started a game of cricket
	Given Player 2 scores 3 runs
	Given Player 2 gets out
	Given Player 1 has started a game of cricket
	Given Player 1 scores 3 runs
	Given Player 1 gets out
	When Both get out
	Then Declare the result as tied