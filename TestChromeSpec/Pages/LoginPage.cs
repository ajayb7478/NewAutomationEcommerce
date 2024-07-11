using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChromeSpec.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver; // restricts access outside the class and made it read only so that it cannot be modified 

        public LoginPage(IWebDriver driver) // Setting a constructer
        {
            this.driver = driver; // connectection between AmazonHomePage object and web browser 
        }

        // storing the web elements in a variable of type web element and making it private so that it won't be accessed outside

        private IWebElement UserName => driver.FindElement(By.XPath("//*[@id=\"user-name\"]"));
        private IWebElement PassWord => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("//*[@id=\"login-button\"]"));

        // Public methods for interacting with elements
        public void EnterUserName(string username)
        {
            UserName.SendKeys(username);
        }
        public void EnterPassWord(string password)
        {
            PassWord.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
    }
}
