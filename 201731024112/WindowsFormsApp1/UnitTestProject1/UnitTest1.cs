﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaoLayer;
using DataBase;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StudentDAO ss = new StudentDAO();
            StudentDataset st = new StudentDataset();
        }
    }
}
