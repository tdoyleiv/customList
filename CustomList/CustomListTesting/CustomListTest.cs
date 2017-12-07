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
            testList.Add("test");
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
        public void Add_AddTwoStrings_IncrementCount()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            //Act
            testList.Add("testOne");
            testList.Add("testTwo");
            //Assert
            Assert.AreEqual(2, testList.Count);
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
            CustomList<int> testList = new CustomList<int>();
            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            //Assert
            Assert.AreEqual(6, testList[5]);
        }
        [TestMethod]
        public void ToString_AddInt_ConvertToString()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            //Act
            string testString = testList.ToString();
            //Assert
            Assert.AreEqual("1", testString);
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_IndexLessThanZero_ArgumentExceptionExpected()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("test");
            //Act
            testList.RemoveAt(-1);
            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_IndexMoreThanCount_ArgumentExceptionExpected()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("test");
            //Act
            testList.RemoveAt(10);
            //Assert
        }
        [TestMethod]
        public void RemoveAt_ListIndexThree_RemoveElementShiftListDownIndex()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            //Act
            testList.RemoveAt(3);
            //Assert
            Assert.AreEqual(5, testList[3]);
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
        [TestMethod]
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
        [TestMethod]
        public void Contains_ListIndexThree_ReturnTrue()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("1");
            testList.Add("2");
            testList.Add("3");
            testList.Add("4");
            testList.Add("5");
            //Act
            bool result = testList.Contains("4");
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Contains_UnindexedValue_ReturnFalse()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            testList.Add("1");
            testList.Add("2");
            testList.Add("3");
            testList.Add("4");
            //Act
            bool result = testList.Contains("5");
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IndexOf_ListIndexThree_ReturnIndexThree()
        {
            //Arrange
            CustomList<long> testList = new CustomList<long>();
            testList.Add(0x100000000);
            testList.Add(0x200000000);
            testList.Add(0x300000000);
            testList.Add(0x400000000);
            testList.Add(0x500000000);
            //Act
            int index = testList.IndexOf(0x400000000);
            //Assert
            Assert.AreEqual(3, index);
        }
        public void GetEnumerator_AddElement_ReturnIteratedValue()
        {
            //Arrange
            CustomList<long> testList = new CustomList<long>();
            testList.Add(0x100000000);
            testList.Add(0x200000000);
            testList.Add(0x300000000);
            testList.Add(0x400000000);
            testList.Add(0x500000000);
            //Act
            foreach(var element in testList)
            {
                testList.Add(0x600000000);
            }
            //Assert
            Assert.AreEqual(0x600000000, testList[1]);
        }
    }
}
