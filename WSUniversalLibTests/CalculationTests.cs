using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest()
        {
            //Arrange
            int productType = 3, materialType = 1, count = 15, expected = 114148;
            float width = 20, length = 45;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest1()
        {
            //Arrange
            int productType = 1, materialType = 1, count = 7, expected = 557;
            float width = 8, length = 9;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest2()
        {
            //Arrange
            int productType = 2, materialType = 2, count = 20, expected = 1519;
            float width = 5, length = 6;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest3()
        {
            //Arrange
            int productType = 3, materialType = 1, count = 4, expected = 83370;
            float width = 145, length = 17;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest4()
        {
            //Arrange
            int productType = 2, materialType = 1, count = 80, expected = 60618;
            float width = 100, length = 19;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest5()
        {
            //Arrange
            int productType = 1, materialType = 1, count = 1, expected = 2;
            float width = 1, length = 1;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest6()
        {
            //Arrange
            int productType = 2, materialType = 2, count = 2, expected = 21;
            float width = 2, length = 2;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest7()
        {
            //Arrange
            int productType = 3, materialType = 2, count = 6, expected = 1825;
            float width = 6, length = 6;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest8()
        {
            //Arrange
            int productType = 2, materialType = 2, count = 9, expected = 1845;
            float width = 9, length = 9;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest9()
        {
            //Arrange
            int productType = 2, materialType = 2, count = 5, expected = 317;
            float width = 5, length = 5;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest10()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 100, expected = 1113361;
            float width = 100, length = 100;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest11()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 200, expected = 8906883;
            float width = 200, length = 200;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest12()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 300, expected = 30060729;
            float width = 300, length = 300;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest13()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 400, expected = 71255061;
            float width = 400, length = 400;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void GetQuantityForProductTest14()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 500, expected = 139170041;
            float width = 500, length = 500;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }






    }


    }