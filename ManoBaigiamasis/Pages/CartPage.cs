using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    class CartPage : BasicPages
    {
        public CartPage(IWebDriver driver) : base(driver) { }

        private IWebElement eShopButton2 => driver.FindElement(By.ClassName("nav-top-link"));
        private IWebElement apsauginesPrekesLeft2 => driver.FindElement(By.LinkText("Apsauginės prekės"));
        private IWebElement itemApsauginesKaukes => driver.FindElement(By.CssSelector(".product-small:nth-child(1) .attachment-woocommerce_thumbnail"));
        private IWebElement apsauginesKaukes => driver.FindElement(By.CssSelector("#product-10653 > div.product-container > div.product-main > div > div.product-info.summary.col-fit.col.entry-summary.product-summary > h1"));
        private IWebElement iKrepseli => driver.FindElement(By.Name("add-to-cart"));
             
        public void PressEshopButton2()
        {
            eShopButton2.Click();
        }
        public void PressApsauginesPrekesLeftSide2()
        {
            apsauginesPrekesLeft2.Click();
        }
        public void PressApsauginesKaukes()
        {
            itemApsauginesKaukes.Click();
        } 
        public void CheckApsauginesKaukesDesplayed()
        {
            Assert.AreEqual("Apsauginė medicininė kaukė (50 vnt.)", apsauginesKaukes.Text);
        }
        public void PressIkrepseli()
        {
            iKrepseli.Click();
        }
    }
}
