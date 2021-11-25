using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTester
{
    class Utility
    {
        public static void Navigate(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
