using DotNetPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetPracticeTest
{


    /// <summary>
    ///This is a test class for SearchHelperTest and is intended
    ///to contain all SearchHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SearchHelperTest
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
        ///A test for DividendSearch
        ///</summary>
        [TestMethod()]
        public void DividendSearchTest()
        {
            // ** Test the dividend search

            int[] targetArray = new int[] { 1, 2, 2, 4, 8 }; // TODO: Initialize to an appropriate value
            SearchHelper target = new SearchHelper(targetArray); // TODO: Initialize to an appropriate value
            int searchNum = 4; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DividendSearch(searchNum);
            Assert.AreEqual(expected, actual);
        }
    }
}
