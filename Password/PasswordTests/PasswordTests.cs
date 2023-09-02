using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordTests
{
    [TestClass]
    public class PasswordTests
    {
        int allPoints;
        [TestMethod]
        public void TestNumberInPass_True_1Pointreturn()
        {
            // Arrage
            string a = "a2"; int expected = 1;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.NumberPassword(a);
            //Assert
            Assert.AreEqual(expected, actual);
            allPoints += actual;
        }
        [TestMethod]
        public void TestStrokeSimbInPass_True_1Pointreturn()
        {
            // Arrage
            string a = "a2As"; int expected = 1;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.StrokeSimbInThePass(a);
            //Assert
            Assert.AreEqual(expected, actual);
            allPoints += actual;
        }

        [TestMethod]
        public void TestUpperSimbInPass_True_1Pointreturn()
        {
            // Arrage
            string a = "a2As"; int expected = 1;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.UpperCaseSimbInThePass(a);
            //Assert
            Assert.AreEqual(expected, actual);
            allPoints += actual;
        }

        [TestMethod]
        public void SpecSimbInPass_True_1Pointreturn()
        {
            // Arrage
            string a = "a2A^./s"; int expected = 1;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.SpecSimbInThePass(a);
            //Assert
            Assert.AreEqual(expected, actual);
            allPoints += actual;
        }
        [TestMethod]
        public void SevenSimbInPass_True_1Pointreturn()
        {
            // Arrage
            string a = "a2Aae./"; int expected = 1;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.SevenSimbInThePass(a);
            //Assert
            Assert.AreEqual(expected, actual);
            allPoints += actual;
        }

        [TestMethod]
        public void NalichiePass_True_1Pointreturn()
        {
            // Arrage
            string a = "1"; int expected = 1;
            // Act
            Password.Password password = new Password.Password();
            int actual = password.NalichiePass(a);
            //Assert
            Assert.AreEqual(expected, actual);
            allPoints += actual;
        }

    }
}
