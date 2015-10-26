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
        int FrameCount = 0;
        bool DoubleStrike = false;
        public void SetPins(int p)
        {
                FinalScore_ += p;
                //if(FrameCount<10)
                if (SpareCheck == true)
                {
                    FinalScore_ += p;
                    SpareCheck = false;
                }
                if (StrikeCheck != -1)
                {
                    FinalScore_ += p;
                    StrikeCheck++;
                    if (DoubleStrike == true)
                    {
                        FinalScore_ += p;
                        StrikeCheck = 1;
                        DoubleStrike = false;
                    }
                    if (p == 10) DoubleStrike = true;
                    if (StrikeCheck == 2) StrikeCheck = -1;
                }
                if (LastPin == -1 && p == 10)
                {
                    FrameCount++;
                    StrikeCheck = 0;
                }
                if (LastPin == -1 && p != 10) LastPin = p;
                else
                {
                    if (LastPin + p == 10) SpareCheck = true;
                    LastPin = -1;
                    FrameCount++;
                }
            }
            
        }

        public int GetFinalScore()
        {
            return FinalScore_;
        }

    }
}
