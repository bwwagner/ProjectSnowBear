using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SnowCrashBank.Models.Profile.cs;

namespace SnowCrashUnitTest1
{
     [TestClass]
     public class ProfileTest
     {
          [TestMethod]
          public void NameTest1()
          {
               SnowCrashBank.Models.Profile test = new SnowCrashBank.Models.Profile();
               string testFirst = null;
               string testLast = null;
               test.LastName = "Jeremy";
               test.FirstMidName = "Schmitt";
               Assert.AreEqual(testLast, test.LastName, "Last Name Incorrect");
               Assert.AreEqual(testFirst, test.FirstMidName, "FirstMid Name Incorrect");
          }
          [TestMethod]
          public void NameTest2()
          {
               SnowCrashBank.Models.Profile test = new SnowCrashBank.Models.Profile();
               string testFirst = null;
               string testLast = "Schmitt";
               test.LastName = "Schmitt";
               test.FirstMidName = "Jeremy";
               Assert.AreEqual(testLast, test.LastName, "Last Name Incorrect");
               Assert.AreEqual(testFirst, test.FirstMidName, "FirstMid Name Incorrect");
          }
          [TestMethod]
          public void NameTest3()
          {
               SnowCrashBank.Models.Profile test = new SnowCrashBank.Models.Profile();
               string testFirst = "Jeremy";
               string testLast = null;
               test.LastName = "Schmitt";
               test.FirstMidName = "Jeremy";
               Assert.AreEqual(testLast, test.LastName, "Last Name Incorrect");
               Assert.AreEqual(testFirst, test.FirstMidName, "FirstMid Name Incorrect");
          }
          [TestMethod]
          public void NameTest4()
          {
               SnowCrashBank.Models.Profile test = new SnowCrashBank.Models.Profile();
               string testFirst = "Jeremy";
               string testLast = "Schmitt";
               test.LastName = "Schmitt";
               test.FirstMidName = "Jeremy";
               Assert.AreEqual(testLast, test.LastName, "Last Name Incorrect");
               Assert.AreEqual(testFirst, test.FirstMidName, "FirstMid Name Incorrect");
          }
     }
}
