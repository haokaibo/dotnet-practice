﻿using DotNetPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DotNetPracticeTest
{


    /// <summary>
    ///这是 TwentyFourPointsGameTest 的测试类，旨在
    ///包含所有 TwentyFourPointsGameTest 单元测试
    ///</summary>
    [TestClass()]
    public class TwentyFourPointsGameTest
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
        ///PointsGame 的测试
        ///</summary>
        [TestMethod()]
        public void PointsGameTest()
        {
            TwentyFourPointsGame target = new TwentyFourPointsGame(); // TODO: 初始化为适当的值
            int n = 4; // TODO: 初始化为适当的值
            int n1 = 1, n2 = 2, n3 = 3, n4 = 4;
            target.number = new double[] { n1, n2, n3, n4 };
            target.result = new string[4] { n1.ToString(), n2.ToString(), n3.ToString(), n4.ToString() };
            bool expected = true; // TODO: 初始化为适当的值
            bool actual;

            actual = target.PointsGame(n);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("(((1+2)+3)*4)", target.result[0]);

        }
    }
}
