using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.SetPins(0);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(0));
        }
        [Test]
        public void NormalPin()
        {
            Game g = new Game();
            for(int i=0;i<20;i++)
            {
                g.SetPins(2);
            }
            Assert.That(g.GetFinalScore(), Is.EqualTo(40));
        }
        [Test]
        public void SpareTest()
        {
            Game g = new Game();
            g.SetPins(2);
            g.SetPins(8);
            g.SetPins(5);
            g.SetPins(4);
            Assert.That(g.GetFinalScore(), Is.EqualTo(24));
        }
        [Test]
        public void AllSpareTest()
        {
            Game g = new Game();
            for(int i=0;i<10;i++)
            {
                g.SetPins(2);
                g.SetPins(8);
            }
            g.SetPins(0);
            Assert.That(g.GetFinalScore(), Is.EqualTo(118));
        }
        //[Test]
    }
}
