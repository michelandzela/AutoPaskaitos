using AutoPaskaitos.ManoBaigiamasis.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class Test2eshop : Basic
    {
       private EShopPage eShopPage;

        [SetUp]

        public void BeforeEveryTestTwo()
        {
            eShopPage = new EShopPage(driver);
        }

        [Test]
        public void EShopPress()
        {
            eShopPage.PressEshopButton();
            eShopPage.CheckEshopOpen();
        }

        [Test]
        public void PressApsauginesPrekesLeft()
        {
            eShopPage.PressEshopButton();
            eShopPage.PressApsauginesPrekesLeftSide();
        }

        [Test]
        public void PressApsauginesPrekesCenter()
        {
            eShopPage.PressEshopButton();
            eShopPage.PressApsauginesPrekesCenter();
        }
       // Kaip sutikrinti, kad paspaudus Left arba Center, atsidaro tas pats langas

    }
}
