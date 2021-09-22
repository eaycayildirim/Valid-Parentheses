using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Parentheses;

namespace UnitTestForParentheses
{
    [TestClass]
    public class UnitTestValidParentheses
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

        [TestMethod]
        public void TestInvalidDigit()
        {
            //Given
            string input = "a()";
            bool expected = false;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestParenthesesStartWithCloseParentheses()
        {
            //Given
            string input = ")(";
            bool expected = false;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDifferentNumbersOfOpenParentheses()
        {
            //Given
            string input = "((((()";
            bool expected = false;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDifferentNumbersOfCloseParentheses()
        {
            //Given
            string input = "())))))))";
            bool expected = false;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestRandomParentheses()
        {
            //Given
            string input = "([())";
            bool expected = false;

            //When
            ValidParentheses valid = new ValidParentheses();
            bool actual = valid.IsInputValid(input);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }
}
