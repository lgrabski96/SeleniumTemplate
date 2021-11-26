using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SpecFlowTester.Drivers
{
    class SeleniumDriver
    {
		private IWebDriver driver;
		private readonly ScenarioContext _scenarioContext;

		public SeleniumDriver(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		public IWebDriver Setup()
		{
			ChromeOptions ChromeDriverOptions = new ChromeOptions();
			ChromeDriverOptions.AddArguments(@"--incognito");
			ChromeDriverOptions.AddArgument(@"--start-maximized");
			ChromeDriverOptions.AddUserProfilePreference("disable-popup-blocking", "true");
			ChromeDriverOptions.AddArguments("--disable-extensions");
			//ChromeDriverOptions.AddExcludedArgument("enable-automation");
			//ChromeDriverOptions.AddAdditionalCapability("useAutomationExtension", false);

			//DesiredCapabilities ChreomeDriverCapabilities = DesiredCapabilities.chrome();
			//ChreomeDriverCapabilities.setCapability(ChromeOptions.CAPABILITY, ChromeDriverOptions);

			WebDriver driver = new ChromeDriver(ChromeDriverOptions);

			//driver = new ChromeDriver(ChromeDriverOptions);

			_scenarioContext.Set(driver, "WebDriver");

			driver.Manage().Window.Maximize();

			return driver;
		}
	}
}
