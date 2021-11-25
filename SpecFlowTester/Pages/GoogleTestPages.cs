using System;
using OpenQA.Selenium;

namespace SpecFlowTester.Pages
{
    class GoogleTestPages
    {
        public static IWebElement GoogleLogo(IWebDriver driver)
        {
            return driver.FindElement(By.Name("q"));
        }
    }
}
