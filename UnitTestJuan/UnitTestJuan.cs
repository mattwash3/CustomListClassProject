using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestJuan
{
    [TestClass]
    public class UnitTestJuan
    {
        [TestMethod]
        public void AddIntegersToCustomList_CheckForZeroIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int expected = 1;

            //Act
            myList.Add(value);
            int actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddIntegerToCustomList_CheckIntergerAtTwoIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int expected = 6;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            int actual = myList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddIntegerToCustomList_CheckIntegerAtThreeIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int expected = 10;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            int actual = myList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFiveIntegersToCustomList_CheckForCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int value4 = 16;
            int expected = 5;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            int actual = myList.Count;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddSixIntegersToCustomList_CheckCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int value4 = 16;
            int value5 = 20;
            int expected = 8;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            int actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFiveIntegersToCustomList_CheckIntegerAtIndexFour()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int value4 = 16;
            int expected = 16;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            int actual = myList[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
   







    
}
