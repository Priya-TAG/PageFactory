using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageFactory
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "foo")]
        private IWebElement fooElement;

        [TestMethod]
        public void TestMethod1()
        {
            fooElement.Click();            
        }
    }
}
