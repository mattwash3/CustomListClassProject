using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestJuan
{
    [TestClass]
    public class UnitTestGarcia
    {
        [TestMethod]
        public void ConvertToString_DisplayCustomListAsString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            string expected = "1, 2, 3";

            //Act
            myList.ToString(value);
            myList.ToString(value1);
            myList.ToString(value2);
            string actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
