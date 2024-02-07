using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BugzillaWebDriver.Tests.WebElementsTests
{
    [TestClass]
    public class ComboBoxTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void GetSelectedValue_InitialValue_ReturnsLow()
        {
            Assert.AreEqual("low", ComboBoxHelper.GetSelectedValue(By.Name("security_level")));
        }

        [TestMethod]
        public void SelectElementByIndex_WithIndexOne_ReturnsMedium()
        {
            ComboBoxHelper.SelectElement(By.Name("security_level"), 1);
            Assert.AreEqual("medium", ComboBoxHelper.GetSelectedValue(By.Name("security_level")));
        }

        [TestMethod]
        public void SelectElementByVisibleText_WithHigh_ReturnsHigh()
        {
            ComboBoxHelper.SelectElement(By.Name("security_level"), "2");
            Assert.AreEqual("high", ComboBoxHelper.GetSelectedValue(By.Name("security_level")));
        }

        [TestMethod]
        public void GetAllItem_WithThreeValues_ReturnsAllThreeValues()
        {
            var expectedItems = new List<string> { "low", "medium", "high" };
            var items = ComboBoxHelper.GetAllItem(By.Name("security_level")).ToList<string>();
            CollectionAssert.AreEqual(expectedItems, items);
        }
    }
}
