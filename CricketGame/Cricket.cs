using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public  int PlayerScore { get; set; }
       // public int PlayeroneScore { get; set; }
       // public int PlayertwoScore { get; set; }
        public bool Playing;
       // public bool PlayerOnePlaying = false;
       // public bool PlayerTwoPlaying = false;
        public Cricket()
        {
            PlayerScore = 0;
            Playing = true;
        }
        public void Score(int runs)
        {
            if (Playing)
            {
                if (runs <= 6)
                {
                    PlayerScore = PlayerScore + runs;
                }
            }
        }

    }
}
