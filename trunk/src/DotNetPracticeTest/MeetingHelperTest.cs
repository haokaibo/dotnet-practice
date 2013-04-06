using System;
using DotNetPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetPracticeTest
{


    /// <summary>
    ///This is a test class for MeetingHelperTest and is intended
    ///to contain all MeetingHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MeetingHelperTest
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
        ///A test for GetMinimumMeetRooms
        ///</summary>
        [TestMethod()]
        public void GetMinimumMeetRoomsTest()
        {
            Meeting[] meetings = new Meeting[]{
                new Meeting(new DateTime(2013,4,8,9,0,0), new DateTime(2013,4,8,10,0,0)),
                new Meeting(new DateTime(2013,4,8,9,0,0), new DateTime(2013,4,8,9,30,0)),
                new Meeting(new DateTime(2013,4,8,9,30,0), new DateTime(2013,4,8,10,0,0)),
                new Meeting(new DateTime(2013,4,8,9,30,0), new DateTime(2013,4,8,10,0,0)),
                new Meeting(new DateTime(2013,4,8,10,0,0), new DateTime(2013,4,8,11,0,0)),
            };

            // TODO: Initialize to an appropriate value
            MeetingHelper target = new MeetingHelper(meetings); // TODO: Initialize to an appropriate value
            int[] expected = new int[] { 1, 2, 2, 3, 1 }; // TODO: Initialize to an appropriate value
            int[] actual;
            actual = target.GetMinimumMeetRooms();

            Assert.IsTrue(MeetingHelperTest.ArrayEquals(expected, actual));
        }

        public static bool ArrayEquals(int[] left, int[] right)
        {
            if (left == null || right == null)
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
                {
                    return false;
                }
            }
            return true;
        }
    }
}
