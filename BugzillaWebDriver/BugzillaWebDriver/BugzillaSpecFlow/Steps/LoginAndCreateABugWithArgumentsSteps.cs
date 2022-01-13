using BugzillaWebDriver.ComponentHelper;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BugzillaSpecFlow.Steps
{
    [Binding]
    public class LoginAndCreateABugWithArgumentsSteps
    {
        [When(@"I provide the username ""(.*)"" and password ""(.*)""")]
        public void WhenIProvideTheUsernameAndPassword(string username, string password)
        {
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), username);
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), password);
        }
        
        [When(@"click on Login button")]
        public void WhenClickOnLoginButton()
        {
            ButtonHelper.ClickButton(By.Id("log_in"));
        }
        
        [When(@"I provide the Severity, Hardware, Platform and Summary")]
        public void WhenIProvideTheSeverityHardwarePlatformAndSummary(Table table)
        {
            foreach(var row in table.Rows)
            {
                ComboBoxHelper.SelectElement(By.Id("bug_severity"), row["Severity"]);
                ComboBoxHelper.SelectElement(By.Id("rep_platform"), row["Hardware"]);
                ComboBoxHelper.SelectElement(By.Id("op_sys"), row["Platform"]);
                TextBoxHelper.TypeInTextBox(By.Id("short_desc"), row["Summary"]);
            }
        }
    }
}
