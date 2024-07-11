using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;
using TestChromeSpec.Pages;

namespace TestChromeSpec.StepDefinitions
{
    [Binding]
    public class UserAuthenticationStepDefinitions
    {

        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private readonly TestContext _testContext;
        public UserAuthenticationStepDefinitions(TestContext testContext)
        {
            _testContext = testContext;  // Constructor to inject TestContext to decide which browser to use
        }

        [Given(@"I open a browser")]
        public void GivenIOpenABrowser()
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

            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
        }

        [When(@"I navigate to ""([^""]*)""")]
        public void WhenINavigateTo(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }

        [Then(@"I type the user name into the text box ""([^""]*)""")]
        public void ThenITypeTheUserNameIntoTheTextBox(string username)
        {
            loginPage.EnterUserName(username);
        }

        [Then(@"I type the password into the password box ""([^""]*)""")]
        public void ThenITypeThePasswordIntoThePasswordBox(string password)
        {
            loginPage.EnterPassWord(password);
        }

        [Then(@"I login")]
        public void ThenILogin()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I verify if I have logged in or not")]
        public void ThenIVerifyIfIHaveLoggedInOrNot()
        {
            Assert.AreEqual("Swag Labs", homePage.GrabHeadingText());
            Console.WriteLine("test is completed");
        }
    }
}
