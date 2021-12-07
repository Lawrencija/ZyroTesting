using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ZyroTest.Pages;

namespace ZyroTest.Tests
{
    class Test : BaseTest
    {
        private Page puslapis;

        public object ExpectedConditions { get; private set; }

        [SetUp]
        public void PriesKiekvienaTesta()
        { 

            puslapis = new Page(driver);
          
        }

        [Test]
        public void DropDown()
        {
            string sablonopavadinimas = "Anders";

            puslapis.paspaustSutinku()
                    .paspaustDizainai()
                    .IeskotiSablono(sablonopavadinimas)
                    .PaspaustiIeskoti()
                    .PasirinktiAnders();
                
                   
                    
                    


        }

       

    }

    
}