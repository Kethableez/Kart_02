using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kart_02;
using System.IO;
using System;

namespace Test_Kart_02
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Kart_02.Program.Main();

                var res = sw.ToString().Trim();
                Assert.AreEqual(Expected, res);
            }
        }
    }
}
