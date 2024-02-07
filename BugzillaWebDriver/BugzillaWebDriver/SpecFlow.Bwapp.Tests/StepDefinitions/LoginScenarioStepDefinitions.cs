using BugzillaWebDriver.BaseClasses;
using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.Bwapp.Tests.StepDefinitions
{
    [Binding]
    public class LoginScenarioStepDefinitions
    {
        [Given(@"User is on Home Page")]
        public void GivenUserIsOnHomePage()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [Given(@"Login and password inputs are visible")]
        public void GivenLoginAndPasswordInputsAreVisible()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.Id("login")));
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.Id("password")));
        }

        [When(@"I provide the login and password and click on Login button")]
        public void WhenIProvideTheLoginAndPasswordAndClickOnLoginButton()
        {
            TextBoxHelper.TypeInTextBox(By.Id("login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Name("form"));
        }

        [Then(@"User should be on portal page")]
        public void ThenUserShouldBeOnPortalPage()
        {
            Assert.AreEqual("http://127.0.0.1/portal.php", PageHelper.GetPageUrl());
        }
    }
}
