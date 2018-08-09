using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]
    public class TeamPlayerScoreSteps
    {
        private Cricket _player1;
        private Cricket _player2;
        [When(@"Players has started a game of cricket")]
        public void WhenPlayersHasStartedAGameOfCricket()
        {
            _player1 = new Cricket();
            _player2 = new Cricket();
        }
        
        [Then(@"the players score should be (.*)")]
        public void ThenThePlayersScoreShouldBe(int score)
        {
            _player1.PlayerScore.Should().Be(score);
            _player2.PlayerScore.Should().Be(score);
        }
        [Given(@"Player 1 has started a game of cricket")]
        public void GivenPlayerOneHasStartedAGameOfCricket()
        {
            _player1 = new Cricket();
            _player1.Playing = true;
        }
        [When(@"Player 1 scores (.*) runs")]
        [Given(@"Player 1 scores (.*) runs")]
        public void WhenPlayerOneScoresRuns(int run)
        {
            _player1.Score(run);
        }

        [Then(@"Player 1 has scored (.*)")]
        public void ThenPlayerOneHasScored(int score)
        {
            _player1.PlayerScore.Should().Be(score);
        }
        [Given(@"Player 1 gets out")]
        public void GivenPlayerGetsOut()
        {
            _player1.Playing = false;
        }

        [Given(@"Player 2 has started a game of cricket")]
        public void GivenPlayerTwoHasStartedAGameOfCricket()
        {
            _player2 = new Cricket();
            _player2.Playing = true;
        }
        [When(@"Player 2 scores (.*) runs")]
        [Given(@"Player 2 scores (.*) runs")]
        public void WhenPlayerTwoScoresRuns(int run)
        {
            _player2.Score(run);
        }
        [Then(@"Player 2 has scored (.*)")]
        public void ThenPlayerTwoHasScored(int score)
        {
            _player2.PlayerScore.Should().Be(score);
        }
        [Given(@"Player 2 gets out")]
        public void GivenPlayer2GetsOut()
        {
            _player2.Playing = false;
        }
        [When(@"Both get out")]
        public void WhenBothGetOut()
        {
            _player1.Playing.Should().Be(false);
            _player2.Playing.Should().Be(false);
        }
        [Then(@"Declare the result Player 2 wins with more runs")]
        public void ThenDeclareTheResultPlayerWinsWithMoreRuns()
        {
            _player2.PlayerScore.Should().BeGreaterThan(_player1.PlayerScore);
        }
        [Then(@"Declare the result as tied")]
        public void ThenDeclareTheResultAsTied()
        {
            _player2.PlayerScore.Should().Be(_player1.PlayerScore);
        }


    }
}
