using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
namespace UnitTestJuan
{
    [TestClass]
    public class UnitTestZip
    {
        CustomList<int> one;
        CustomList<int> two;
        CustomList<string> str1;
        CustomList<string> str2;

        [TestMethod]
        public void ZipCustomListsTogether_CheckCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            one = new CustomList<int>();
            two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 4;
            int value5 = 6;
            int expected = 6;

            //Act
            one.Add(value);
            one.Add(value2);
            one.Add(value4);
            two.Add(value1);
            two.Add(value3);
            two.Add(value5);
            list = one.Zip(two);
            int actual = list.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipCustomListsTogether_CheckCapacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            one = new CustomList<int>();
            two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 4;
            int value5 = 6;
            int expected = 6;

            //Act
            one.Add(value);
            one.Add(value2);
            one.Add(value4);
            two.Add(value1);
            two.Add(value3);
            two.Add(value5);
            list = one.Zip(two);
            int actual = list.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void ZipCustomListsTogether_CheckIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            one = new CustomList<int>();
            two = new CustomList<int>();
            int value = 1;
            int value1 = 3;
            int value2 = 5;
            int value3 = 2;
            int value4 = 4;
            int value5 = 6;
            int expected = 6;

            //Act
            one.Add(value);
            one.Add(value2);
            one.Add(value4);
            two.Add(value1);
            two.Add(value3);
            two.Add(value5);
            list = one.Zip(two);
            int actual = list[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void ZipCustomListsTogether_CheckIndexString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            str1 = new CustomList<string>();
            str2 = new CustomList<string>();
            string value = "Why";
            string value1 = "You";
            string value2 = "Mix";
            string value3 = "Up";
            string value4 = "This";
            string value5 = "Sentence";
            string expected = "Yo";


            //Act
            str1.Add(value);
            str1.Add(value2);
            str1.Add(value4);
            str2.Add(value1);
            str2.Add(value3);
            str2.Add(value5);
            list = str1.Zip(str2);
            string actual = list[6];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
