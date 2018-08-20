using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCoreReceiver;

namespace UnitTestCoreReceiver
{
    [TestClass]
    public class UnitTestReceiver
    {
        [TestMethod]
        public void DisplaySentMessage()
        {
            string msg = "Hello my name is, Kat";
            string expected = "Hello Kat , I am your father!";

            Assert.AreEqual(expected, Prompt.ReturnPrompt(msg));
        }
    }
}

