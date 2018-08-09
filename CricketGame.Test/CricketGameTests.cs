using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Test
{
    [TestClass]
    public class CricketGameTests
    {
        Cricket game = new Cricket();
        [TestMethod]
        public void PlayerScore_NewGame_ShouldbeZero()
        {
            //Assert.Inconclusive();
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayerScore()
        {
            // var game = new Cricket();
            game.Score(3);
            //Assert.Inconclusive();
            Assert.IsTrue(game.PlayerScore == 3);
        }
        [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayerScore()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
    }
}
