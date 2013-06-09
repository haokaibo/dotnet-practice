using DotNetPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotNetPracticeTest
{


    /// <summary>
    ///这是 SortingHelperTest 的测试类，旨在
    ///包含所有 SortingHelperTest 单元测试
    ///</summary>
    [TestClass()]
    public class SortingHelperTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///QuickSortArray Test for the 
        ///</summary>
        [TestMethod()]
        public void QuickSortArrayTest()
        {
            int[] originArray = { 2, 1 }; // TODO: 初始化为适当的值
            int[] expected = { 1, 2 }; // TODO: 初始化为适当的值
            int[] actual;
            actual = new SortingHelper().QuickSortArray(originArray);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            originArray = new int[] { 3, 2, 1 }; // TODO: 初始化为适当的值
            expected = new int[] { 1, 2, 3 }; // TODO: 初始化为适当的值
            actual = new SortingHelper().QuickSortArray(originArray);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            originArray = new int[] { 40, 30, 20, 10 }; // TODO: 初始化为适当的值
            expected = new int[] { 10, 20, 30, 40 }; // TODO: 初始化为适当的值
            actual = new SortingHelper().QuickSortArray(originArray);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            originArray = new int[] { 20, 30, 40, 10 }; // TODO: 初始化为适当的值
            expected = new int[] { 10, 20, 30, 40 }; // TODO: 初始化为适当的值
            actual = new SortingHelper().QuickSortArray(originArray);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            originArray = new int[] { 5, 30, 40, 10 }; // TODO: 初始化为适当的值
            expected = new int[] { 5, 10, 30, 40 }; // TODO: 初始化为适当的值
            actual = new SortingHelper().QuickSortArray(originArray);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }

        /// <summary>
        ///QuickSortArray test for the ArgumentNullException
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSortArrayFailedOnArgumentIsNullTest()
        {
            int[] originArray = null; // TODO: 初始化为适当的值
            int[] actual;
            actual = new SortingHelper().QuickSortArray(originArray);
        }
    }
}
