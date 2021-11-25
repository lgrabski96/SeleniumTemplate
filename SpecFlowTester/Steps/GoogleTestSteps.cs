using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowTester.Drivers;
using TechTalk.SpecFlow;
using static SpecFlowTester.Utility;
using static SpecFlowTester.Pages.GoogleTestPages;

namespace SpecFlowTester.Steps
{
    [Binding]
    public sealed class GoogleTestSteps
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public GoogleTestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        static IWebDriver driver;

        [Given(@"I open homepage ""(.*)""")]
        public void GivenIOpenHomepage(string url)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            Navigate(driver, url);
        }

        [Then(@"Homepage should appear")]
        public void ThenHomepageShouldAppear()
        {
            Assert.IsTrue(GoogleLogo(driver).Displayed);
        }
    }
}

