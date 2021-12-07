using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZyroTest.Pages
{
    class Page : BasePages
    {
        public Page(IWebDriver driver) : base(driver) { }

        private IWebElement Slapukai => driver.FindElement(By.CssSelector(".medium-up:nth-child(4)"));

        private IWebElement dizainai => driver.FindElement(By.XPath("//span[contains(.,'Dizainai')]"));

        private IWebElement paieskosLaukas => driver.FindElement(By.XPath("//input[@type='text']"));

        private IWebElement paieskosMygtukas => driver.FindElement(By.CssSelector(".search__button-icon > use"));

        private IWebElement AndersShop => driver.FindElement(By.CssSelector(".template:nth-child(1) .button:nth-child(2)"));

        private IWebElement ShopNow => driver.FindElement(By.Id("m_B5R5csF"));







        public Page paspaustSutinku()
        {
                Slapukai.Click();
                return this;
            
        }

        public Page paspaustDizainai()
        {
            dizainai.Click();
            return this;

        }


        public Page IeskotiSablono(string sablonopavadinimas)
        {
            paieskosLaukas.SendKeys(sablonopavadinimas);
            return this;
        }

        public Page PaspaustiIeskoti()
        {
            paieskosMygtukas.Click();
            return this;
        }

        public Page PasirinktiAnders()
        {
            AndersShop.Click();
            return this;
        }

        public Page Pirkti()
        {
            ShopNow.Click();
            return this;
        }

       
    }
}
