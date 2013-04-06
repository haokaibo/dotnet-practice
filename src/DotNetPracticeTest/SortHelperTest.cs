using DotNetPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetPracticeTest
{


    /// <summary>
    ///This is a test class for SortHelperTest and is intended
    ///to contain all SortHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SortHelperTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for QuickSort
        ///</summary>
        [TestMethod()]
        public void QuickSortTest()
        {
            int[] targetArray = { 4, 1, 3, 2 }; // TODO: Initialize to an appropriate value
            SortHelper target = new SortHelper(targetArray); // TODO: Initialize to an appropriate value
            int[] expected = { 1, 2, 3, 4 }; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = target.QuickSort();
            Assert.IsTrue(ArrayEqual(expected, actual), string.Format("expected: {0} ", expected.ToString()));
        }

        private bool ArrayEqual(int[] left, int[] right)
        {
            if (null == left || null == right)
            {
                return false;
            }
            if (left.Length != right.Length)
            {
                return false;
            }
            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] == right[i])
                {
                    continue;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
