using System;
using OpenQA.Selenium;

namespace SpecFlowTester.Pages
{
    class GoogleTestPages
    {
        public static IWebElement GoogleSignIn(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//*[text()='Sign in']"));
        }

        public static IWebElement GoogleSearchbar(IWebDriver driver)
        {
            return driver.FindElement(By.Name("q"));
        }

        public static IWebElement GoogleSearchButton(IWebDriver driver)
        {
            return driver.FindElement(By.Name("Google Search"));
            //return driver.FindElement(By.XPath("//*[contains(text(), 'Google Search')]")); 
        }

        public static IWebElement GoogleWikiSearch(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//*[text()='Something(Beatles song) - Wikipedia']"));
        }
    }
}
