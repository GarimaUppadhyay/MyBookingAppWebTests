using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookingWebAppTests.Pages
{
    public class BasePage
    {
        IWebDriver _webDriver;
        TestContext _testContext;
        WebDriverWait _webDriverWait;

        public BasePage(WebDriverWait webDriverWait, IWebDriver webDriver, TestContext testContext)
        {
            _webDriver = webDriver;
            _testContext = testContext;
            _webDriverWait = webDriverWait;
        }
        public LoginPage LoginPage
        {
            get
            {
                return new LoginPage(_webDriverWait, _webDriver, _testContext);
            }
        }
        public AppointmentPage AppointmentPage
        {
            get
            {
                return new AppointmentPage(_webDriverWait, _webDriver, _testContext);
            }
        }
    }
}