using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutoPaskaitos.ManoBaigiamasis.Tests
{
    class Basic
    {
        public IWebDriver driver;

        [SetUp]

        public void BeforeEveryTest()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.biomedikoscentras.lt/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
