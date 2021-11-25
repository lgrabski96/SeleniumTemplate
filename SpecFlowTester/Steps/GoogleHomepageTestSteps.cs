using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SpecFlowTester.Drivers;
using TechTalk.SpecFlow;
using static SpecFlowTester.Utility;
using static SpecFlowTester.Pages.GoogleTestPages;

namespace SpecFlowTester.Steps
{
    [Binding]
    public sealed class GoogleHomepageTestSteps
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public GoogleHomepageTestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        static IWebDriver driver;

        //Blok wspóldzielonych metod

        [Given(@"I open homepage ""(.*)""")]
        public void GivenIOpenHomepage(string url)
        {
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();

            Navigate(driver, url);
        }

        //Blok metod testu @Searchbar

        [Then(@"Homepage should appear")]
        public void ThenHomepageShouldAppear()
        {
            Assert.IsTrue(GoogleSignIn(driver).Displayed);
        }

        //Blok metod testu @SearchingSomething
    }
        
}

