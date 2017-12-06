using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTesting
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void getSet_returnEnteredValue_returnValue()
        {
            //Arrange
            CustomList<TestCategoryAttribute> testList = new CustomList<TestCategoryAttribute>();
            int i = 0;
            //Act
            TestCategoryAttribute testValue = testList[i];
            //Assert
            Assert.AreEqual(testValue, testList[i]);
        }

        [TestMethod]
        public void add_addInt_returnValueEX()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int testValue = 1;
            //Act
            testList.AddElement(testValue);
            //Assert
            Assert.AreEqual(testValue, testList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void add_addStringIndex_IndexExceptionExpected()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testValue = "test";
            //Act
            testList.AddElement(testValue);
            //Assert
            Assert.AreEqual(testValue, testList[10]);
        }
        public void add_addBool_returnValueEX3()
        {
            //Arrange
            CustomList<bool> testList = new CustomList<bool>();
            bool testValue = false;
            //Act
            testList.AddElement(testValue);
            //Assert
            Assert.AreEqual(testValue, testList[0]);
        }
    }
}
