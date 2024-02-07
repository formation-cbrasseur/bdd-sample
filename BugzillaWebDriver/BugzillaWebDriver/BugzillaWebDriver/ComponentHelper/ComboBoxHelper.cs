using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BugzillaWebDriver.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;

        public static void SelectElement(By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);
        }

        public static void SelectElement(By locator, string visibletext)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(visibletext);
        }

        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
        
        public static string GetSelectedValue(By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.SelectedOption.Text;
        }
    }
}
