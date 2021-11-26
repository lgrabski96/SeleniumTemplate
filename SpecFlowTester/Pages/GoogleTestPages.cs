using System;
using OpenQA.Selenium;

namespace SpecFlowTester.Pages
{
    class GoogleTestPages
    {
        public static IWebElement GooglePermisions(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//div[@id=\"uMousc\"]"));
        }

        public static IWebElement GooglePermisionsAcceptButton(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//button[@id=\"L2AGLb\"]"));
        }
        

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
            //return driver.FindElement(By.Name("Google Search"));
            return driver.FindElement(By.XPath("//input[@Value=\"Google Search\"]")); 
        }

        public static IWebElement GoogleWikiSearch(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Something(Beatles song) - Wikipedia"));
            //return driver.FindElement(By.XPath("//*[contains(text(), 'Something(Beatles song) - Wikipedia')]")); //mozna używać *
        }
    }
}
