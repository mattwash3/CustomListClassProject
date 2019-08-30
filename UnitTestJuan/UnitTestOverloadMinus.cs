using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestJuan
{
    [TestClass]
    public class UnitTestOverloadMinus
    {
        CustomList<int> one;
        CustomList<int> two;

        [TestMethod]
        public void OverloadMinusOperator_SubtractOneInstanceOfClassFromAnother()
        {
            //Arrange
            one = new CustomList<int>();
            two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 1;
            int value5 = 6;
            int expected = 3;

            //Act
            one.Add(value);
            one.Add(value1);
            one.Add(value2);
            two.Add(value3);
            two.Add(value4);
            two.Add(value5);
            one = one - two;
            int actual = one[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadMinusOperator_TestCount()
        {
            //Arrange
            one = new CustomList<int>();
            two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 1;
            int expected = 3;

            //Act
            one.Add(value);
            one.Add(value1);
            one.Add(value2);
            two.Add(value3);
            two.Add(value4);
            one = one - two;
            int actual = one.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
