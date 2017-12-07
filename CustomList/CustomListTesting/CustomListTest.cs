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
            //Act
            testList.Add(1);
            //Assert
            Assert.AreEqual(1, testList[0]);
        }
        [TestMethod]
        public void Add_AddString_ReturnValueEX2()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            //Act
            testList.Add("test");
            //Assert
            Assert.AreEqual("test", testList[0]);
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
            //Act
            testList.Add(false);
            //Assert
            Assert.AreEqual(1, testList.Count);
        }
        [TestMethod]
        public void Add_AddDoubleOverCapacity_ExpectedCount()
        {
            //Arrange
            CustomList<double> testList = new CustomList<double>();
            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            //Assert
            Assert.AreEqual(6, testList.Count);
        }
        [TestMethod]
        public void Add_AddUIntOverCapacity_ExpectedList()
        {
            //Arrange
            CustomList<uint> testList = new CustomList<uint>();
            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            //Assert
            Assert.AreEqual("1 2 3 4 5 6", joinedList);
        }
        [TestMethod]
        public void ToString_AddInt_ConvertToString()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            //Act
            testList.ToString();
            //Assert
            Assert.AreEqual("1", testList[0]);
        }
        [TestMethod]
        public void Remove_NoElementFound_ReturnFalse()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            //Act
            testList.Add("test");
            testList.Add("testTwo");
            //Assert
            Assert.IsFalse(testList.Remove("testThree"));
        }
        [TestMethod]
        public void Remove_ListIndexZero_ReturnTrue()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            //Act
            bool result = testList.Remove(1);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Remove_ListIndexZero_ReturnNewIndexValue()
        {
            //Arrange
            CustomList<long> testList = new CustomList<long>();
            testList.Add(1);
            testList.Add(2);
            //Act
            testList.Remove(1);
            //Assert
            Assert.AreEqual(2, testList[0]);
        }
        public void Remove_ListIndexZero_DecrementCount()
        {
            //Arrange
            CustomList<float> testList = new CustomList<float>();
            testList.Add(1);
            testList.Add(2);
            //Act
            testList.Remove(1);
            //Assert
            Assert.AreEqual(1, testList.Count);
        }
    }
}
