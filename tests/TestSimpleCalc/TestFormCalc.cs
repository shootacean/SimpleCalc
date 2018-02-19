using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSimpleCalc
{
    [TestClass]
    public class TestFormCalc
    {
        [TestMethod]
        public void TestMethod1()
        {
            var I = new SimpleCalc.FormCalc();
            Assert.AreEqual(I.GetModeString(SimpleCalc.FormCalc.Mode.Add), "+");
            Assert.AreEqual(I.GetModeString(SimpleCalc.FormCalc.Mode.Minus), "-");
            Assert.AreEqual(I.GetModeString(SimpleCalc.FormCalc.Mode.Multi), "×");
            Assert.AreEqual(I.GetModeString(SimpleCalc.FormCalc.Mode.Div), "÷");
        }
    }
}
