using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<Product> products = new List<Product>()
        {
         new Product(){catagory="Toy", price=300},
         new Product(){catagory="Toy", price=300},
         new Product(){catagory="Toy", price=300},
         new Product(){catagory="Toy", price=300},
        };

        [TestMethod]
        public void Can_Sum_Product_Corretly()
        { 
            
        //Arrange
        // Repository
            DiscountHelper repo = new DiscountHelper();       
            decimal ExpectedValue = products.Sum(m => m.price) + 0.9M;

        //Act
        //callin class
        LinqValueCalculator target = new LinqValueCalculator(repo);
        decimal ActualValue = target.ProductValue(products);

        //Assert
            Assert.AreEqual(ExpectedValue, ActualValue);     
        
        
        }


        /// <summary>
        /// ////////////////////////////////////////
        /// </summary>


        [TestMethod]
        public void CanSumIt()
        {
            //Arrange
            Int32 a = 55;
            Int32 b = 33;

            Int32 ExpectedValue = 88;


            //Act
            //Calling Class
            HomeController target = new HomeController();
            //Calling-function
            Int32 ActualValue = target.SumIt(a,b);

            //Assert
            Assert.AreEqual(ExpectedValue, ActualValue);
        }
    }
}
