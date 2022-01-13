using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BugzillaWebDriver.Tests.FindElements
{
    [TestClass]
    public class FindElementTests
    {
        [TestMethod]
        public void GetElementTests()
        {
            try
            {
                ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void GetElementsTests()
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine(elements.Count);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void GetElementFromGenericHelper()
        {
            Assert.IsNotNull(GenericHelper.GetElement(By.LinkText("File a Bug")));
        }

        [TestMethod]
        public void IsElementPresentOnce()
        {
            Assert.IsTrue(ObjectRepository.Driver.FindElements(By.LinkText("File a Bug")).Count == 1);
        }

        [TestMethod]
        public void IsElementPresentOnceFromGenericHelper()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.LinkText("File a Bug")));
        }
    }
}
