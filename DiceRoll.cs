using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace Mission2
{
    internal class DiceRoll
    {
        //import random and create the array to keep track of scores
        Random random = new Random();
        private int[] scores = new int[11];
        
        public int[] Roll(int numRolls) // Roll method
        {
            for (int i = 0; i < numRolls; i++) // for the number of rolls specified...
            {
                // Generate random numbers (1-6) for each die
                int rollValue1 = random.Next(1, 7);
                int rollValue2 = random.Next(1, 7);

                // appends to the score array depending on what the combo of the 2 dice is
                if (rollValue1 + rollValue2 == 2)
                {
                    scores[0] += 1;
                }
                else if (rollValue1 + rollValue2 == 3)
                {
                    scores[1] += 1;
                }
                else if (rollValue1 + rollValue2 == 4)
                {
                    scores[2] += 1;
                }
                else if (rollValue1 + rollValue2 == 5)
                {
                    scores[3] += 1;
                }
                else if (rollValue1 + rollValue2 == 6)
                {
                    scores[4] += 1;
                }
                else if (rollValue1 + rollValue2 == 7)
                {
                    scores[5] += 1;
                }
                else if (rollValue1 + rollValue2 == 8)
                {
                    scores[6] += 1;
                }
                else if (rollValue1 + rollValue2 == 9)
                {
                    scores[7] += 1;
                }
                else if (rollValue1 + rollValue2 == 10)
                {
                    scores[8] += 1;
                }
                else if (rollValue1 + rollValue2 == 11)
                {
                    scores[9] += 1;
                }
                else if (rollValue1 + rollValue2 == 12)
                {
                    scores[10] += 1;
                }                
            }
            return scores; // returns the now populated array to the main program
        }
        
    }
}
