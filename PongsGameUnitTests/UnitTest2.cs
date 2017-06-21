using System;
using PongGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PongsGameUnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestX()
        {
            PongGame.Ball target = new Ball();
            double x = 1.25;
            target.X = x;
            Assert.AreEqual(target.X, x);
        }
    }
}
