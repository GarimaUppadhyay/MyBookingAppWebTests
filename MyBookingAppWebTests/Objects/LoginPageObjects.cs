using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookingWebAppTests.Objects
{
    public class LoginPageObjects
    {
        #region class members
        IWebDriver _driver;
        WebDriverWait _wait;
        #endregion

        #region Constructor
        public LoginPageObjects(WebDriverWait wait, IWebDriver webDriver)
        {
            _wait = wait;
            _driver = webDriver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
        #endregion
        #region Class Properties
        public IWebElement Email
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.XPath(LoginPageLocators.Email)));

            }
        }
        public IWebElement Password
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(LoginPageLocators.Password)));

            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(LoginPageLocators.LoginButton)));

            }
        }
        #endregion
    }
    public static class LoginPageLocators
    {
        public static string Email = "email_ID";
        public static string Password = "password_ID";
        public static string LoginButton = "LoginButton_ID";
    }

}