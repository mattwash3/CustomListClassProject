using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestLopez
{
    [TestClass]
    public class UnitTestLopez
    {
        CustomList<int> one;
        CustomList<int> two;

        [TestMethod]
        public void OverloadPlusOperator()
        {
            //Arrange
            one = new CustomList<int>();
            two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int expected = 1;

            //Act
            one.Add(value);
            one.Add(value1);
            one.Add(value2);
            two.Add(value);
            two.Add(value1);
            two.Add(value2);
            CustomList<int> list = one + two;
            int actual = list[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadPlusOperator_Count()
        {
            //Arrange
            one = new CustomList<int>();
            two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int expected = 6;

            //Act
            one.Add(value);
            one.Add(value1);
            one.Add(value2);
            two.Add(value);
            two.Add(value1);
            two.Add(value2);
            CustomList<int> list = one + two;
            int actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
