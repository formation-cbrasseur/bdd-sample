using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugzillaWebDriver.Tests.WebElementsTests
{
    [TestClass]
    public class ComboBoxTests
    {
        [TestMethod]
        public void ComboBoxListTests()
        {
            NavigationHelper.NavigateToHomePage();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            ComboBoxHelper.SelectElement(By.Id("bug_severity"), 2);
            ComboBoxHelper.SelectElement(By.Id("bug_severity"), "blocker");
            foreach (string str in ComboBoxHelper.GetAllItem(By.Id("bug_severity")))
            {
                Console.WriteLine("Text : {0}", str);
            }
            NavigationHelper.Logout();
        }
    }
}
