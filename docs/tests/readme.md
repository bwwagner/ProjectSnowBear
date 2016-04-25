This is a folder to store test files and their descriptions.

---
#####UI_TEST_ONE.html  
*Test Description:*  
This is a Selenium IDE [(version 2.9.0)](https://github.com/SeleniumHQ/selenium/wiki/SeIDEReleaseNotes) 
automated test which was created using the Firefox Extension.  It tests the basic functions of the website.
It requires opening the localhost version of the website or security permissions from the browser.
A full successful test starts at the home/index and finishes at the [project snowcrash github page](https://github.com/bwwagner/ProjectSnowCrash).

*Current Status:*  
+ Failure Under Firefox 45.0.1
+ Obsolete, fails at transfer money button because the button no longer exists.

#####UI_TEST_TWO.html  
*Test Description:*  
This is a Selenium IDE [(version 2.9.0)](https://github.com/SeleniumHQ/selenium/wiki/SeIDEReleaseNotes)   
automated test which was created using the Firefox Extension.  It is the second version to test the basic  
functions of the website. It requires opening the localhost version of the website or security permissions from the browser.
A full successful test starts and finishes at the /home/Index.

*Current Status:*  
+ Passes Under Firefox 45.0.1


---
#####ProfileTest.cs
*Test Description:*
These are unit tests written in C# under the Visual Studio 2015 NUnit.  They test basic properties
of the account class.
Unit Test Descriptions:
- NameTest1 is a null failure. 
- NameTest2 is an intentional null Failure on firstmidname.
- NameTest3 is an intentional null Failure on lastname
- NameTest4 is supplied with matching data

*Current Status: 1/4 Passed*
+ NameTest1: Failure, Message: Assert.AreEqual.failed. Expected:\<null\>. Actual:\<Jeremy\>. Last Name Incorrect
+ NameTest2: Failure, Message: Assert.AreEqual.failed. Expected:\<null\>. Actual:\<Jeremy\>. FirstMid Name Incorrect
+ NameTest3: Failure, Message: Assert.AreEqual.failed. Expected:\<null\>. Actual:\<Schmitt\>. Last Name Incorrect
+ NameTest4: Passed
