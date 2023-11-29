using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestClass]
    public class DropdownTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void VerifyNumberOfItemsInDropdown()
        {
          
            driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/select-dropdown-menu/");

           
            IWebElement dropdown = driver.FindElement(By.CssSelector("#post-2646 > div.twelve.columns > div > div > div > p > select"));

           
            var options = dropdown.FindElements(By.TagName("option"));

            
            Assert.AreEqual(249, options.Count, "Number of items in the dropdown is not equal to 249");
        }

        [TestCleanup]
        public void TearDown()
        {
            
            driver.Quit();
        }
    }
}
