using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTesting
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void get_returnEnteredValue_returnValue()
        {
            //Arrange
            Indexer<TestCategoryAttribute> indexer = new Indexer<TestCategoryAttribute>();
            int i = 0;
            //Act
            TestCategoryAttribute testValue = indexer[i];
            //Assert
            Assert.AreEqual(testValue, indexer[i]);
        }

        [TestMethod]
        public void get_returnEnteredValue_returnValueEX()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int testValue = 1;
            //Act
            testList.Add(1);
            //Assert
            Assert.AreEqual(testValue, testList[0]);
        }

        [TestMethod]
        // additional attribute for "expect exception thrown"
        public void get_returnEnteredValue_returnValueEX2()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int testValue = 1;
            //Act
            testList.Add(1);
            //Assert
            Assert.AreEqual(testValue, testList[10]);
        }
    }
}
