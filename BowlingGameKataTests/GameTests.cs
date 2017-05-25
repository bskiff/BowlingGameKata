using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGameKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata.Tests
{
    [TestClass()]
    public class GameTests
    {
        private Game game;

        private void rollNTimes(int val, int n)
        {
            for (int i = 0; i < n; i++)
            {
                game.roll(val);
            }
        }

        [TestInitialize]
        public void setup()
        {
            game = new Game();
        }

        [TestMethod()]
        public void gutterGame()
        {
            rollNTimes(0, 20);
            Assert.AreEqual(0, game.score());
        }

        [TestMethod()]
        public void onesGame()
        {
            rollNTimes(1, 20);
            Assert.AreEqual(20, game.score());
        }

        [TestMethod()]
        public void singleSpare()
        {
            game.roll(5);
            game.roll(5);
            game.roll(3);
            rollNTimes(0, 17);
            Assert.AreEqual(16, game.score());
        }

        [TestMethod()]
        public void singleStrike()
        {
            game.roll(10);
            game.roll(6);
            game.roll(2);
            rollNTimes(0, 16);
            Assert.AreEqual(26, game.score());
        }

        [TestMethod()]
        public void perfectGame()
        {
            rollNTimes(10, 10);
            Assert.AreEqual(300, game.score());
        }
    }
}