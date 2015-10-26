using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {
        int FinalScore_ = 0;
        bool SpareCheck = false;
        int StrikeCheck = -1;
        int LastPin = -1;
        public void SetPins(int p)
        {
            FinalScore_+=p;
            if (SpareCheck == true)
            {
                FinalScore_ += p;
                SpareCheck = false;
            }
          //  if()
            if (LastPin == -1) LastPin = p;
            else
            {
                if (LastPin + p == 10)   SpareCheck = true;
                LastPin = -1;
            }
        }

        public int GetFinalScore()
        {
            return FinalScore_;
        }

    }
}
