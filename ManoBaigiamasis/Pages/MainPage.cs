using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    class MainPage : BasicPages
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        private IWebElement logInButton => driver.FindElement(By.CssSelector("#masthead > div.header-inner.flex-row.container.logo-center.medium-logo-center > div.flex-col.hide-for-medium.flex-right > ul > li.account-item.has-icon > a > i"));
        private IWebElement emailBox => driver.FindElement(By.Id("username"));
        private IWebElement password => driver.FindElement(By.Id("password"));
        private IWebElement logIn => driver.FindElement(By.Name("login"));
        private IWebElement fault => driver.FindElement(By.LinkText("Netinkamas vartotojo vardas. ")); // del sitos
        private IWebElement wrong => driver.FindElement(By.LinkText(" yra neteisingas. ")); // del sitos
        public void PressLogInButton()
        {
            logInButton.Click();
        }
        public void WriteCorrectEmail()
        {
            string email = "j.michalcenko@gmail.com";
            emailBox.SendKeys(email);
        }
        public void WriteCorrectPassword()
        {
            string mypassword = "AutoTestavimas2020";
            password.SendKeys(mypassword);
        }
        public void PressPrisijungti()
        {
            logIn.Click();
        }
        public void WriteBadEmail()
        {
            string bademail = "something";
            emailBox.SendKeys(bademail);
        }
        public void WriteBadPassword()
        {
            string badpassword = "badpassword";
            password.SendKeys(badpassword);
        }
        public void CheckFault()
        {
            Assert.AreEqual("Netinkamas vartotojo vardas. ", fault.Text); // del sitos
        }
        public void CheckWrongPassword()
        {
            Assert.AreEqual(" yra neteisingas. ", wrong.Text); // del sitos
        }
    }
}
