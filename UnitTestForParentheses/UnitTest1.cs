using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Parentheses;

namespace UnitTestForParentheses
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOneTypeValidParentheses()
        {
            //Given
            string input = "()";
            bool expected = true;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDifferentTypeValidParentheses()
        {
            //Given
            string input = "[()()]";
            bool expected = true;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestInvalidParentheses()
        {
            //Given
            string input = "[({)}()]";
            bool expected = false;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
