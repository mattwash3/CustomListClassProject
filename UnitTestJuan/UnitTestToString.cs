using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestJuan
{
    [TestClass]
    public class UnitTestToString
    {
        [TestMethod]
        public void ConvertToString_CheckString()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            string expected = "1,2,3";

            //Act
            list.Add(value);
            list.Add(value1);
            list.Add(value2);
            string stringList = list.ToString();
            string actual = stringList;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void ToString_CheckStringTestTwo()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "";

            //Act
            string stringList = list.ToString();
            string actual = stringList;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void ElementArray_ToString_ReturnStringElements()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            string value = "Hello!";
            string value1 = "How";
            string value2 = "Are";
            string value3 = "You?";
            string expected = "Hello! How Are You?";

            //Act
            list.Add(value);
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
