using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestChromeSpec.PageObjects;

namespace TestChromeSpec.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private IWebDriver driver;
        private AmazonHomePage amazonHomePage; // Create an instance of the PO class

        [Given(@"I open the browser")]
        public void GivenIOpenTheBrowser()
        {
            driver = new ChromeDriver();
            amazonHomePage = new AmazonHomePage(driver); // Initialize PO class with driver
        }

        [When(@"I navigate to ""([^""]*)""")]
        public void WhenINavigateTo(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string searchTerm)
        {
            amazonHomePage.EnterSearchTerm(searchTerm);
            amazonHomePage.ClickSearchButton();// Use PO class method
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
