using DotNetPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetPracticeTest
{


    /// <summary>
    ///这是 IntelligentLiftTest 的测试类，旨在
    ///包含所有 IntelligentLiftTest 单元测试
    ///</summary>
    [TestClass()]
    public class IntelligentLiftTest
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
        ///GetTheBestFloor 的测试
        ///</summary>
        [TestMethod()]
        public void GetTheBestFloor1Test()
        {
            int N = 6; // TODO: 初始化为适当的值
            int[] personTargets = new int[N + 1]; // TODO: 初始化为适当的值
            for (int i = 1; i <= N; i++)
            {
                personTargets[i] = i;
            }
            IntelligentLift target = new IntelligentLift(N, personTargets); // TODO: 初始化为适当的值
            BestFloor expected = new BestFloor() { nTargetFloor = 2, nMinFloor = 4 }; // TODO: 初始化为适当的值
            BestFloor actual;
            actual = target.GetTheBestFloor1();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTheBestFloor2
        ///</summary>
        [TestMethod()]
        public void GetTheBestFloor2Test()
        {
            int N = 6; // TODO: Initialize to an appropriate value
            int[] personTargets = new int[N + 1]; // TODO: Initialize to an appropriate value
            IntelligentLift target = new IntelligentLift(N, personTargets); // TODO: Initialize to an appropriate value
            BestFloor expected = new BestFloor() { nTargetFloor = 2, nMinFloor = 4 }; // TODO: Initialize to an appropriate value
            BestFloor actual;
            actual = target.GetTheBestFloor2();
            Assert.AreEqual(expected, actual);
        }
    }
}
