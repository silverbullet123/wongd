using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCoreSender;

namespace UnitTestCoreSender
{
    [TestClass]
    public class TestCoreSender
    {
        [TestMethod]
        public void CheckPrompt()
        {
            string expected = "Enter name.";
            Assert.AreEqual(expected, Prompt.DisplayEnterMsg());
        }

         [TestMethod]
        public void DisplaySentMessage()
        {
            string msg = "Cat";
            string expected = "Sent message : " + msg; ;
            Assert.AreEqual(expected, Prompt.DisplaySentMessage(msg));
        }
    }
}
