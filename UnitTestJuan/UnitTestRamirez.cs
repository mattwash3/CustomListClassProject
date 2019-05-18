using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestJuan
{
    public class UnitTestRamirez
    {
            [TestMethod]
            public void RemoveIndexValueFromCustomList_CheckCount()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value = 1;
                int value1 = 3;
                int value2 = 6;
                int value3 = 10;
                int expected = 3;


                //Act
                myList.Add(value);
                myList.Add(value1);
                myList.Add(value2);
                myList.Add(value3);
                myList.Remove(value);
                int actual = myList.Count;

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void RemoveValueFromCustomList_CheckCapacity()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value = 1;
                int value1 = 3;
                int value2 = 6;
                int value3 = 10;
                int expected = 4;


                //Act
                myList.Add(value);
                myList.Add(value1);
                myList.Add(value2);
                myList.Add(value3);
                myList.Remove(value);
                int actual = myList.Capacity;

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void RemoveValueAtIndex_MoveIndexesOverToFillIn_CheckIndexAtRemovedIndexSpot()
            {
                //Arrange
                CustomList<int> myList = new CustomList<int>();
                int value = 1;
                int value1 = 3;
                int value2 = 6;
                int value3 = 10;
                int expected = 6;

                //Act
                myList.Add(value);
                myList.Add(value1);
                myList.Add(value2);
                myList.Add(value3);
                myList.Remove(value1);
                int actual = myList[1];

                //Assert
                Assert.AreEqual(expected, actual);
            }

            //[TestMethod]
            //public void Remove()
            //{
            //    //Arrange
            //    CustomList<int> myList = new CustomList<int>();
            //    int value = 1;
            //    int value1 = 3;
            //    int value2 = 6;
            //    int value3 = 10;
            //    int expected = ;

            //    //Act
            //    myList.Add(value);
            //    myList.Add(value1);
            //    myList.Add(value2);
            //    myList.Add(value3);
            //    int actual = ;

            //    //Assert
            //    Assert.AreEqual(expected, actual);
            //}

    }

}
