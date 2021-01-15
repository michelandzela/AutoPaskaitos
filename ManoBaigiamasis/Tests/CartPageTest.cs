using AutoPaskaitos.ManoBaigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class CartPageTest : Basic
    {
        private CartPage cartPage;

        [SetUp]
        public void beforeEveryTests()
        {
            cartPage = new CartPage(driver);
            cartPage.PressEshopButton2();
            cartPage.PressApsauginesPrekesLeftSide2();
        }

        [Test]
        public void ShoppingSelection()
        {
            cartPage.PressApsauginesKaukes();
            cartPage.CheckApsauginesKaukesDesplayed();
        }
        [Test]
        public void ShoppingCart()
        {
            cartPage.PressApsauginesKaukes();
            cartPage.PressIkrepseli();
        }
    }
}
