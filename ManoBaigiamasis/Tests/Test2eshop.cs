using AutoPaskaitos.ManoBaigiamasis.Pages;
using NUnit.Framework;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class Test2eshop : Basic
    {
       private EShopPage eShopPage;

        [SetUp]

        public void BeforeEveryTestTwo()
        {
            eShopPage = new EShopPage(driver);
            eShopPage.PressEshopButton();
        }

        [Test]
        public void EShopPress()
        {
            eShopPage.CheckEshopOpen();
        }

        [Test]
        public void PressApsauginesPrekesLeft()
        {
            eShopPage.PressApsauginesPrekesLeftSide();

            Assert.AreEqual("https://www.biomedikoscentras.lt/kategorija/medicinines-prekes/", driver.Url);
        }

        [Test]
        public void PressApsauginesPrekesCenter()
        {
            eShopPage.PressApsauginesPrekesCenter();

            Assert.AreEqual("https://www.biomedikoscentras.lt/kategorija/medicinines-prekes/", driver.Url);
        }

        [Test]
        public void ReturnToHomePage()
        {
            eShopPage.HomeButton();

            Assert.AreEqual("https://www.biomedikoscentras.lt/", driver.Url);
        }
    }
}
