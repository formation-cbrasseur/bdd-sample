using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Bwapp.Tests.StepDefinitions
{
    [Binding]
    public class LogoutScenarioStepDefinitions
    {
        [Given(@"Logout link is visible")]
        public void GivenLogoutLinkIsVisible()
        {
            GenericHelper.IsElementPresentOnce(By.LinkText("Logout"));
        }

        [When(@"I click on logout link")]
        public void WhenIClickOnLogoutLink()
        {
            LinkHelper.ClickLink(By.LinkText("Logout"));
        }

        [When(@"I click on OK on pop-up")]
        public void WhenIClickOnOKOnPop_Up()
        {
            AlertHelper.Accept();
            // Needs to wait on this particular project because project is going to portal.php before going to logout.php
            Task.Delay(100).Wait();
        }

        [Then(@"User is on login page")]
        public void ThenUserIsOnLoginPage()
        {
            Assert.AreEqual("bWAPP - Login", PageHelper.GetPageTitle());
        }

    }
}
