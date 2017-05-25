using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {
        private int[] totalPins = new int[21];
        private int currentPin = 0;

        public void roll(int pins)
        {
            totalPins[currentPin++] = pins;
            if (pins == 10)
            {
                currentPin++;
            }
        }

        public int score()
        {
            var total = 0;
            for (int i = 0; i < 20; i += 2) {
                var frameScore = totalPins[i] + totalPins[i + 1];
                if(totalPins[i] == 10)
                {
                    total += totalPins[i + 2] + totalPins[i + 3];
                } else if (frameScore == 10)
                {
                    total += totalPins[i + 2];
                }
                total += frameScore;
            }

            return total;
        }
    }
}
