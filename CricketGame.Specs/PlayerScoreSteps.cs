using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        public int PreviousScore = 0;
        [When(@"Player has started a game of cricket")]
        [Given(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }
        [Given(@"Player has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int run)
        {
               _game.PlayerScore = run;
        }
        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }
        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int run)
        {
            _game.Score(run);
        }
        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.Playing = false;
        }
        [Then(@"The player score after out should be (.*)")]
        public void ThenThePlayerScoreAfterOutShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);
        }
    }
}
