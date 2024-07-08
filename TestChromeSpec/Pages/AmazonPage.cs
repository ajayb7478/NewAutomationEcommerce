
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestChromeSpec.Pages
{
    public class AmazonPage
    {
        private readonly IWebDriver _driver;

        public AmazonPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchBox => _driver.FindElement(By.XPath("//*[@id=\"twotabsearchtextbox\"]"));
        public IWebElement SearchButton => _driver.FindElement(By.XPath("//input[@id='nav-search-submit-button']"));


    }

}
