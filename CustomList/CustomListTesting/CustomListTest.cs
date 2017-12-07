using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTesting
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Indexer_GetValue_ReturnGetValue()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            int i = 0;
            //Act
            testList.Add("test");
            //Assert
            Assert.AreEqual("test", testList[i]);
        }
        public void Indexer_SetValue_ReturnSetValue()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            //Act
            testList.Add(5);
            testList[0] = 10;
            int expected = 10;
            //Assert
            Assert.AreEqual(expected, testList[0]);
        }
        [TestMethod]
        public void Add_AddInt_ReturnValueEX()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int testValue = 1;
            //Act
            testList.Add(testValue);
            //Assert
            Assert.AreEqual(testValue, testList[0]);
        }
        [TestMethod]
        public void Add_AddString_ReturnValueEX2()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testValue = "test";
            //Act
            testList.Add(testValue);
            //Assert
            Assert.AreEqual(testValue, testList[0]);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Add_AddString_IndexExceptionExpected()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            //Act
            string result = testList[10];
            //Assert
        }
        [TestMethod]
        public void Add_AddBool_IncrementCount()
        {
            //Arrange
            CustomList<bool> testList = new CustomList<bool>();
            bool testValue = false;
            //Act
            testList.Add(testValue);
            //Assert
            Assert.AreEqual(1, testList.Count);
        }
        [TestMethod]
        public void Add_AddDoubleOverCapacity_ExpectedCount()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>();
            double testValueOne = 1;
            double testValueTwo = 2;
            double testValueThree = 3;
            double testValueFour = 4;
            double testValueFive = 5;
            double testValueSix = 6;
            //Act
            testList.Add(testValueOne);
            testList.Add(testValueTwo);
            testList.Add(testValueThree);
            testList.Add(testValueFour);
            testList.Add(testValueFive);
            testList.Add(testValueSix);
            //Assert
            Assert.AreEqual(6, testList.Count);
        }
        [TestMethod]
        public void Add_AddUIntOverCapacity_ExpectedList()
        {
            CustomList<uint> testList = new CustomList<uint>();
            //Arrange
            uint testValueOne = 1;
            uint testValueTwo = 2;
            uint testValueThree = 3;
            uint testValueFour = 4;
            uint testValueFive = 5;
            uint testValueSix = 6;
            //Act
            testList.Add(testValueOne);
            testList.Add(testValueTwo);
            testList.Add(testValueThree);
            testList.Add(testValueFour);
            testList.Add(testValueFive);
            testList.Add(testValueSix);
            //Assert
            //Foreach...get list
        }

    }
}
