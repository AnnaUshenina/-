using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Быстрая_сортировка;

namespace QuickSortTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThreeElements()
        {
            var array = new[] { 3, 1, 2 };
            
            Sort.QuickSort(array, 0, array.Length-1);
            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(3, array[2]);            
        }

        [TestMethod]
        public void HundredElements()
        {
            var array = new int [100];
            for (int i=0;i<100; i++)
                array[i] = 2;
            Sort.QuickSort(array, 0, array.Length - 1);
            for (int i = 0; i < 100; i++)
                Assert.AreEqual(2, array[i]);
        }

        [TestMethod]
        public void ThousandElements()
        {
            var array = new int[1000];
            var rnd = new Random();
            for (int i = 0; i < 1000; i++)
                array[i] = rnd.Next();
            Sort.QuickSort(array, 0, array.Length - 1);
            for (int i = 100; i < 1000; i=i+100)
                Assert.IsTrue(array[i]<array[i+1]);
        }

        [TestMethod]
        public void NonElements()
        {
            var array = new int[0];
            Sort.QuickSort(array, 0, array.Length - 1);
            foreach(int e in array)
                Assert.IsNull(e);
        }

        [TestMethod]
        public void ReallyBigArray()
        {
            var array = new int[1500000000];
            var rnd = new Random();
            for (int i = 0; i < 1500000000; i++)
                array[i] = rnd.Next();
            Sort.QuickSort(array, 0, array.Length - 1);
            for (int i = 0; i < 1500000000; i++)
                Assert.IsTrue(array[i] < array[i + 1]);
        }
    }
}
