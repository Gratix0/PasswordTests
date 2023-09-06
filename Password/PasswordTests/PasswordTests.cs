using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordTests
{
    [TestClass]
    public class PasswordTests
    {
        
        [TestMethod]
        public void TestingPass_Password_5()
        {
            // Arrage
            string a = "1Aa!Patr"; int expected = 5;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.TestingPassword(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }     
        
        [TestMethod]
        public void TestingPass_Password_4()
        {
            // Arrage
            string a = "1Aagatr"; int expected = 4;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.TestingPassword(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingPass_Password_3()
        {
            // Arrage
            string a = "1agatrr"; int expected = 3;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.TestingPassword(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingPass_Password_2()
        {
            // Arrage
            string a = "1agatr"; int expected = 2;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.TestingPassword(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingPass_Password_1()
        {
            // Arrage
            string a = "aa"; int expected = 1;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.TestingPassword(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }     
        [TestMethod]
        public void TestingPass_Password_0()
        {
            // Arrage
            string a = ""; int expected = 0;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.TestingPassword(a);
            //Assert
            
            Assert.AreEqual(expected, actual);
        }     


    }
}
