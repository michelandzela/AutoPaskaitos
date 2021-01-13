using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPaskaitos.ManoBaigiamasis.Pages
{
    public class BasicPages
    {
        protected IWebDriver driver;
        
        public BasicPages(IWebDriver driver)
        {
            this.driver = driver;
        } 
    }
}
