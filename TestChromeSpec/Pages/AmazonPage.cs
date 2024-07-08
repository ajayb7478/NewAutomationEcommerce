using OpenQA.Selenium;

namespace TestChromeSpec.PageObjects
{
    public class AmazonHomePage  // Class name for amazon home page
    {
        private readonly IWebDriver driver; // restricts access outside the class and made it read only so that it cannot be modified 

        public AmazonHomePage(IWebDriver driver) // Setting a constructer
        {
            this.driver = driver; // connectection between AmazonHomePage object and web browser 
        }

        // storing the web elements in a variable of type web element and making it private so that it won't be accessed outside

        private IWebElement SearchBox => driver.FindElement(By.XPath("//*[@id=\"twotabsearchtextbox\"]"));
        private IWebElement SearchButton => driver.FindElement(By.XPath("//input[@id='nav-search-submit-button']"));

        // Public methods for interacting with elements
        public void EnterSearchTerm(string searchTerm)
        {
            SearchBox.SendKeys(searchTerm); // Se
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }
    }
}
