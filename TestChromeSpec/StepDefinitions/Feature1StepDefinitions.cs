using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace TestChromeSpec.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        IWebDriver driver;
        [Given(@"I open the browser")]
        public void GivenIOpenTheBrowser()
        {
            driver = new ChromeDriver();
        }

        [When(@"I navigate to ""([^""]*)""")]
        public void WhenINavigateTo(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string p0)
        {
            driver.FindElement(By.XPath("//*[@id=\"twotabsearchtextbox\"]")).SendKeys(p0);
            driver.FindElement(By.XPath("//input[@id='nav-search-submit-button']")).Click();
            
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
