using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Ibrahim]"));
        }

        [TestMethod]
        public void OnlyRightBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Ibrahim["));
        }
       
        [TestMethod]
        public void OnlyRightBracketAndFalseEqual()
        {
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void OnlyLeftBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Ibrahim]"));
        }

        [TestMethod]
        public void FacingOppositeBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][Ibrahim]["));
        }

        [TestMethod]
        public void DoubleBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Ibrahim]]"));
        }
        [TestMethod]
        public void TribleBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[Ibrahim]From Launch]Code]"));
        }
        [TestMethod]
        public void NoBracketAndTrueAreEqual()
        {
            Assert.AreEqual(true,BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void UnmachBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }
        [TestMethod]
        public void balanceBracketsAndTrueAreEqual()
        {
            Assert.AreEqual(true,BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void EmptyAndTrue()
        {
            Assert.AreEqual(true,BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void FalseAndUnbalance()
        {
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets("[[]"));
        }



        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
    }
}
