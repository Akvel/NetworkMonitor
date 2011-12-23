using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using PService.tests;

using PService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PTdd
{
    [TestClass]
    public class UnitPTest
    {
        [TestMethod]
        public void TestPingIP()
        {
            TPing ping = new TPing("192.168.1.1");
            ITest iping = ping;
            PResult result = iping.getTest();
            Assert.AreEqual(result.errCode, 0);

            ping = new TPing("192.168.1.2");
            iping = ping;
            result = iping.getTest();
            Assert.AreNotEqual(result.errCode, 0);

        }

        [TestMethod]
        public void TestPingHost()
        {
            TPing ping = new TPing("ya.ru");
            ITest iping = ping;
            PResult result = iping.getTest();
            Assert.AreEqual(result.errCode, 0);

            ping = new TPing("ya123456789qqqqq.ru");
            iping = ping;
            result = iping.getTest();
            Assert.AreNotEqual(result.errCode, 0);

        }


        [TestMethod]
        public void TestTraceIP()
        {
            TTracert ping = new TTracert("192.168.1.1");
            ITest iping = ping;
            PResult result = iping.getTest();
            Assert.AreEqual(result.errCode, 0);

            ping = new TTracert("192.168.1.2");
            iping = ping;
            result = iping.getTest();
            Assert.AreNotEqual(result.errCode, 0);

        }

        [TestMethod]
        public void TestTraceHost()
        {
            TTracert ping = new TTracert("ya.ru");
            ITest iping = ping;
            PResult result = iping.getTest();
            Assert.AreEqual(result.errCode, 0);

            ping = new TTracert("ya123456789qqqqq.ru");
            iping = ping;
            result = iping.getTest();
            Assert.AreNotEqual(result.errCode, 0);

        }
    }
}
