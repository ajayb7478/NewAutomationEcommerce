using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChromeSpec.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver; // restricts access outside the class and made it read only so that it cannot be modified 

        public HomePage(IWebDriver driver) // Setting a constructer
        {
            this.driver = driver; // connectection between AmazonHomePage object and web browser 
        }

        // storing the web elements in a variable of type web element and making it private so that it won't be accessed outside

        private IWebElement PageHeading => driver.FindElement(By.XPath("//*[@id=\"header_container\"]/div[1]/div[2]/div"));
        //private IWebElement PassWord => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        //private IWebElement LoginButton => driver.FindElement(By.XPath("//*[@id=\"login-button\"]"));

        // Public methods for interacting with elements
        public String GrabHeadingText()
        {
            string x = PageHeading.Text;
            return x;
        }
    }
}
