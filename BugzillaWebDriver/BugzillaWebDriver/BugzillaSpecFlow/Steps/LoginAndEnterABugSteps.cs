using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using BugzillaWebDriver.Configuration;
using BugzillaWebDriver.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BugzillaSpecFlow.Steps
{
    [Binding]
    public class LoginAndCreateBugFeatureOfTheBugZilaWebPageSteps
    {
        [Given(@"User is at Home Page")]
        public void GivenUserIsAtHomePage()
        {
            NavigationHelper.NavigateToHomePage();
        }
        
        [Given(@"File a Bug Link should be visible")]
        public void GivenFileABugLinkShouldBeVisible()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.LinkText("File a Bug")));
        }
        
        [When(@"I click on File a Bug Link")]
        public void WhenIClickOnFileABugLink()
        {
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
        }
        
        [When(@"I provide the username, password and click on Login button")]
        public void WhenIProvideTheUsernamePasswordAndClickOnLoginButton()
        {
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetUsername());
            ButtonHelper.ClickButton(By.Id("log_in"));
        }
        
        [When(@"I click on Logout button")]
        public void WhenIClickOnLogoutButton()
        {
            NavigationHelper.Logout();
        }
        
        [When(@"I provide the severity, hardware, platform and summary")]
        public void WhenIProvideTheSeverityHardwarePlatformAndSummary()
        {
            ComboBoxHelper.SelectElement(By.Id("bug_severity"), "blocker");
            ComboBoxHelper.SelectElement(By.Id("rep_platform"), "PC");
            ComboBoxHelper.SelectElement(By.Id("op_sys"), "Windows");
            TextBoxHelper.TypeInTextBox(By.Id("short_desc"), "Summary description");
        }

        [When(@"click on Submit button")]
        public void WhenClickOnSubmitButton()
        {
            ButtonHelper.ClickButton(By.Id("commit"));
        }
        
        [Then(@"User should be at Login Page")]
        public void ThenUserShouldBeAtLoginPage()
        {
            Assert.AreEqual("Log in to Bugzilla", PageHelper.GetPageTitle());
        }
        
        [Then(@"User Should be at Enter Bug page")]
        public void ThenUserShouldBeAtEnterBugPage()
        {
            Assert.AreEqual("Enter Bug: TestProduct", PageHelper.GetPageTitle());
        }
        
        [Then(@"User should be logged out and should be at Home Page")]
        public void ThenUserShouldBeLoggedOutAndShouldBeAtHomePage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.Id("welcome")));
        }

        [Then(@"Bug should get created")]
        public void ThenBugShouldGetCreated()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.Id("commit_top")));
        }
        
        [Then(@"User should be at Bug Detail page")]
        public void ThenUserShouldBeAtBugDetailPage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.Id("short_desc_nonedit_display")));
        }
    }
}
