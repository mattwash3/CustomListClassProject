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

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }

        public void AddIntegerToCustomList_CheckIntergerAtOneIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(value1, myList[1]);
        }

        public void AddIntegerToCustomList_CheckIntegerAtFourIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            //Assert
            Assert.AreEqual(value3, myList[3]);
        }

        public void AddFiveIntegersToCustomList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int value4 = 16;
            int expectedCount = 5;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            //Assert
            Assert.AreEqual(expectedCount, myList.Count);
        }

        public void AddFiveIntegersToCustomList_CheckIntegerAtIndexOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int value4 = 16;
            int expectedCount = 5;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            //Assert
            Assert.AreEqual(value1, myList[1]);
        }

        public void AddFiveIntegersToCustomList_CheckIntegerAtIndexFour()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int value4 = 16;
            int expectedCount = 5;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            //Assert
            Assert.AreEqual(value3, myList[4]);
        }

        public void RemoveSpecificIntegerFromCustomList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            int expectedCount = 1;

            //Act
            myList.Add(value);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value1);

            //Assert
            Assert.AreEqual(expectedCount, myList.Remove(value1));
        }
    }
}
