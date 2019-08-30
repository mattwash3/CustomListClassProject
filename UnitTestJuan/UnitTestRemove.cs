using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestRamirez
{
    [TestClass]
    public class UnitTestRamirez
    {
            [TestMethod]
            public void RemoveIndexValueFromCustomList_CheckCount()
            {
                //Arrange
                CustomList<int> list = new CustomList<int>();
                int value = 1;
                int value1 = 3;
                int value2 = 6;
                int value3 = 10;
                int expected = 3;


                //Act
                list.Add(value);
                list.Add(value1);
                list.Add(value2);
                list.Add(value3);
                list.Remove(value);
                int actual = list.Count;

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void RemoveValueFromCustomList_CheckCapacity()
            {
                //Arrange
                CustomList<int> list = new CustomList<int>();
                int value = 1;
                int value1 = 3;
                int value2 = 6;
                int value3 = 10;
                int expected = 4;


                //Act
                list.Add(value);
                list.Add(value1);
                list.Add(value2);
                list.Add(value3);
                list.Remove(value);
                int actual = list.Capacity;

                //Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void RemoveValueAtIndex_MoveIndexesOverToFillIn_CheckIndexAtRemovedIndexSpot()
            {
                //Arrange
                CustomList<int> list = new CustomList<int>();
                int value = 1;
                int value1 = 3;
                int value2 = 6;
                int value3 = 10;
                int expected = 6;

                //Act
                list.Add(value);
                list.Add(value1);
                list.Add(value2);
                list.Add(value3);
                list.Remove(value1);
                int actual = list[1];

                //Assert
                Assert.AreEqual(expected, actual);
            }

        [TestMethod]
        public void RemoveFromList_CheckFalse()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 6;
            int value3 = 10;
            bool expected = false;

            //Act
            list.Add(value);
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            bool actual = list.Remove(value3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void RemoveFromList_CheckCounter()
        {
            // arrange
            CustomList<int> list = new CustomList<int>();
            int value = 1;
            int value1 = 5;
            int expected = 1;



            // act
            list.Add(value);
            list.Add(value1);
            list.Remove(value1);
            int actual = list.Count;


            // assert
            Assert.AreEqual(expected, actual);
        }
    }

}
