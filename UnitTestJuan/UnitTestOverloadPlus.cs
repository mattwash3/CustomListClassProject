using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestLopez
{
    [TestClass]
    public class UnitTestLopez
    {
        [TestMethod]
        public void OverloadPlusOperator_AddTwoListsTogether()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 4;
            int value5 = 6;
            int expected = 6;

            //Act
            one.Add(value);
            one.Add(value1);
            one.Add(value2);
            two.Add(value3);
            two.Add(value4);
            two.Add(value5);
            int actual = ;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 4;
            int value5 = 6;
            int expected = ;

            //Act
            one.Add(value);
            one.Add(value1);
            one.Add(value2);
            two.Add(value3);
            two.Add(value4);
            two.Add(value5);
            int actual = ;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 4;
            int value5 = 6;
            int expected = ;

            //Act
            one.Add(value);
            one.Add(value1);
            one.Add(value2);
            two.Add(value3);
            two.Add(value4);
            two.Add(value5);
            int actual = ;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
