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
            CustomList<int> myList = new CustomList<int>();
            CustomList<int> yourList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 4;
            int value5 = 6;
            //int expected = 6;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            yourList.Add(value3);
            yourList.Add(value4);
            yourList.Add(value5);
            //int actual = myList + yourList;

            //Assert
            //Assert.AreEqual(expected, actual);
        }








    }
}
