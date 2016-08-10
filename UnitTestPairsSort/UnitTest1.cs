using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairsSort;

namespace UnitTestPairsSort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreationPair()
        {
            Pair<string, string> pair = new Pair<string, string>("one", "two");
            Assert.AreEqual("one", pair.First);
            Assert.AreEqual("two", pair.Second);
        }

        [TestMethod]
        public void TestSortEmptyList()
        {
            ArrayList list = new ArrayList();
            list = StaticSort.sort(list);
            Assert.AreEqual(0, list.Count);
            list = StaticSort.sort(null);
            Assert.IsNull(list);
        }
        
        [TestMethod]
        public void TestSortTwoPairs()
        {
            ArrayList list = new ArrayList();
            list.Add(new Pair<string, string>("two", "three"));
            list.Add(new Pair<string, string>("one", "two"));
            list = StaticSort.sort(list);
            Assert.AreEqual("one", ((Pair<string, string>)list[0]).First);
        }

        [TestMethod]
        public void TestSortLongList()
        {
            ArrayList list = new ArrayList();
            list.Add(new Pair<string, string>("two", "three"));
            list.Add(new Pair<string, string>("one", "two"));
            list.Add(new Pair<string, string>("8", "9"));
            list.Add(new Pair<string, string>("17", "18"));
            list.Add(new Pair<string, string>("19", "20"));
            list.Add(new Pair<string, string>("15", "16"));
            list.Add(new Pair<string, string>("10", "11"));
            list.Add(new Pair<string, string>("7", "8"));
            list.Add(new Pair<string, string>("5", "6"));
            list.Add(new Pair<string, string>("14", "15"));
            list.Add(new Pair<string, string>("18", "19"));
            list.Add(new Pair<string, string>("three", "4"));
            list.Add(new Pair<string, string>("13", "14"));
            list.Add(new Pair<string, string>("11", "12"));
            list.Add(new Pair<string, string>("16", "17"));
            list.Add(new Pair<string, string>("20", "21"));
            list.Add(new Pair<string, string>("9", "10"));
            list.Add(new Pair<string, string>("4", "5"));
            list.Add(new Pair<string, string>("12", "13"));
            list.Add(new Pair<string, string>("6", "7"));
            list = StaticSort.sort(list);
            Assert.AreEqual("one", ((Pair<string, string>)list[0]).First);
            Assert.AreEqual("21", ((Pair<string, string>)list[list.Count - 1]).Second);
        }
    }
}
