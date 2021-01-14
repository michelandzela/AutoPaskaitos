using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    class EShopPage : BasicPages
    {
        public EShopPage(IWebDriver driver) : base(driver) { }

        private IWebElement eShopButton => driver.FindElement(By.ClassName("nav-top-link"));
        private IWebElement eShopWritten => driver.FindElement(By.ClassName("shop-page-title"));
        private IWebElement apsauginesPrekesLeft => driver.FindElement(By.LinkText("Apsauginės prekės"));
        private IWebElement apsauginesPrekesCenter => driver.FindElement(By.ClassName("col-inner"));

        public void PressEshopButton()
        {
            eShopButton.Click();
        }
        public void CheckEshopOpen()
        {
            Assert.IsTrue(eShopWritten.Displayed); // paklausti, ar teisingai
        }
        public void PressApsauginesPrekesLeftSide()
        {
            apsauginesPrekesLeft.Click();
        }
        public void PressApsauginesPrekesCenter()
        {
            apsauginesPrekesCenter.Click();
        }


    }

   
   
}
