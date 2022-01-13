using BugzillaWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BugzillaSpecFlow.Steps
{
    [Binding]
    public class LoginFailWhenWrongParametersSuppliedSteps
    {
        [Then(@"User Should be at Wrong Password Page")]
        public void ThenUserShouldBeAtWrongPasswordPage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.Id("error_msg")));
        }
    }
}
