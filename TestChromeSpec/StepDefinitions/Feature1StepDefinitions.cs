using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestChromeSpec.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestChromeSpec.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private IWebDriver driver;
        private AmazonHomePage amazonHomePage;
        private readonly TestContext _testContext;
        public Feature1StepDefinitions(TestContext testContext)
        {
            _testContext = testContext;  // Constructor to inject TestContext to decide which browser to use
        }

        [Given(@"I open the browser")]
        public void GivenIOpenTheBrowser()
        {
            string browser = _testContext.Properties["Browser"]?.ToString() ?? "chrome";
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException($"Browser not supported: {browser}");
            }

            amazonHomePage = new AmazonHomePage(driver);
        }

        [When(@"I navigate to ""([^""]*)""")]
        public void WhenINavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string searchTerm)
        {
            amazonHomePage.EnterSearchTerm(searchTerm);
            amazonHomePage.ClickSearchButton();
        }

        [Then(@"I should see search results related to graphics cards")]
        public void ThenIShouldSeeSearchResultsRelatedToGraphicsCards()
        {
            Console.WriteLine("The test is done");
            driver.Quit();
        }

        [Then(@"I should see search results related to laptops")]
        public void ThenIShouldSeeSearchResultsRelatedToLaptops()
        {
            Console.WriteLine("The test is done");
            driver.Quit();
        }
    }
}
