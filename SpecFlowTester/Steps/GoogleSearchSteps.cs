using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SpecFlowTester.Drivers;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static SpecFlowTester.Utility;
using static SpecFlowTester.Pages.GoogleTestPages;
using System.Threading;

namespace SpecFlowTester.Steps
{
    [Binding]
    public sealed class GoogleSearchSteps
    {
        static IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public GoogleSearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Given I Navigate to ""(.*)""")]
        public void GivenIOpenHomepage(string url)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            Navigate(driver, url);

            if (GooglePermisions(driver).Displayed)
            {
                GooglePermisionsAcceptButton(driver).Click();
            }
        }

        [When(@"I enter searched frase")]
        public void WhenIEnterSearchedFrase()
        {
            GoogleSearchbar(driver).Click();
            GoogleSearchbar(driver).Clear();
            GoogleSearchbar(driver).SendKeys(SearchedFrase());
        }

        [When(@"Press search button")]
        public void WhenPressSearchButton()
        {
            GoogleSearchButton(driver).Click();
        }

        [Then(@"I find Serched element")]
        public void ThenIFindSerchedElement()
        {
            Assert.IsTrue(GoogleWikiSearch(driver).Displayed);
        }

    }

}

