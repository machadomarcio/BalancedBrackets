using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BalancedBracketsTest
{
    [TestClass]
    public class BalancedBracketsTest
    {
        [TestMethod]
        public void Should_Valid_BalancedBrackets_Examples1()
        {
            var valid = BalancedBrackets.BalancedBrackets.ExecuteValidBalancedBrackets("(){}[]");
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Should_Valid_BalancedBrackets_Examples2()
        {
            var valid = BalancedBrackets.BalancedBrackets.ExecuteValidBalancedBrackets("[{()}](){}");
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Should_Invalid_BalancedBrackets_Examples3()
        {
            var valid = BalancedBrackets.BalancedBrackets.ExecuteValidBalancedBrackets("[]{()");
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void Should_Invalid_BalancedBrackets_Examples4()
        {
            var valid = BalancedBrackets.BalancedBrackets.ExecuteValidBalancedBrackets("[{)]");
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void Should_Invalid_BalancedBrackets_Examples5()
        {
            var valid = BalancedBrackets.BalancedBrackets.ExecuteValidBalancedBrackets("{[}]");
            Assert.IsFalse(valid);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Please enter at least 1 characters")]
        public void Should_Return_Exception_BalancedBrackets_Examples6()
        {
            var valid = BalancedBrackets.BalancedBrackets.ExecuteValidBalancedBrackets("");
            Assert.IsFalse(valid);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Invalid characters")]
        public void Should_Return_Exception_BalancedBrackets_Examples7()
        {
            var valid = BalancedBrackets.BalancedBrackets.ExecuteValidBalancedBrackets("{a}[B]");
            Assert.IsFalse(valid);
        }
    }
}
