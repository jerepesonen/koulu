using Microsoft.VisualStudio.TestTools.UnitTesting;
using T36_Ostoskärry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T36_Ostoskärry.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void CountTest0()
        {
            // arrange
            List<Product> products = new List<Product> {};
            int expected = 0;

            // act
            int actual = Product.Count(products);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountTest1()
        {
            // arrange
            Product product1 = new Product() { Nimi = "Milk", Hinta = 1.4 };
            List<Product> products = new List<Product> { product1 };
            int expected = 1;

            // act
            int actual = Product.Count(products);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountTest2()
        {
            // arrange
            Product product1 = new Product() { Nimi = "Milk", Hinta = 1.4 };
            Product product2 = new Product() { Nimi = "Bread", Hinta = 2.2 };
            List<Product> products = new List<Product> { product1, product2 };
            int expected = 2;

            // act
            int actual = Product.Count(products);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountTest5()
        {
            // arrange
            Product product1 = new Product() { Nimi = "Milk", Hinta = 1.4 };
            Product product2 = new Product() { Nimi = "Bread", Hinta = 2.2 };
            Product product3 = new Product() { Nimi = "Butter", Hinta = 3.2 };
            Product product4 = new Product() { Nimi = "Cheese", Hinta = 4.2 };
            Product product5 = new Product() { Nimi = "Ham", Hinta = 3.5 };
            List<Product> products = new List<Product> { product1, product2, product3, product4, product5 };
            int expected = 5;

            // act
            int actual = Product.Count(products);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}