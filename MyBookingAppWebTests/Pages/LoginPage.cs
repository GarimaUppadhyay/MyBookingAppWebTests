using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MyBookingWebAppTests.Objects;
using MyBookingWebAppTests.Helper;

namespace MyBookingWebAppTests.Pages
{
    public class LoginPage
    {
        #region Class members
        WebDriverWait _wait;
        IJavaScriptExecutor executor;
        IWebDriver _driver;
        TestContext _testContext;
        LoginPageObjects loginPageObject;
        AppointmentPageObjects appointmentPageObjects;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for LoginPage
        /// </summary>
        /// <param name="wait"></param>
        /// <param name="driver"></param>
        /// <param name="testContext"></param>
        public LoginPage(WebDriverWait wait, IWebDriver driver, TestContext testContext)
        {
            _wait = wait;
            executor = (IJavaScriptExecutor)driver;
            _driver = driver;
            _testContext = testContext;
            loginPageObject = new LoginPageObjects(_wait, _driver);
            appointmentPageObjects = new AppointmentPageObjects(_wait, _driver);
        }
        #endregion

        /// <summary>
        /// Method for login user details
        /// </summary>
        /// <param name="emailid"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateUserLogin(string emailid, string password)
        {
            bool loginSuccess = true;
           try
            {
               
                loginPageObject.Email.SendKeys(emailid);
                loginPageObject.Password.SendKeys(password);
                loginPageObject.LoginButton.Click();
               
                if (appointmentPageObjects.NewAppointmentButton.Displayed)
                {
                    _testContext.WriteLine("Successfully Login  {0}", emailid);
                    loginSuccess=true;
                }
                else
                loginSuccess=false;
              
                CommonUtilities.CaptureScreenshot("Login", _driver, _testContext);
            }
            catch (Exception e)
            {
                loginSuccess = false;
                _testContext.WriteLine("Error login emailid {0}", e.Message);
                CommonUtilities.CaptureScreenshot("ErrorWhileLogin", _driver, _testContext);
            }
            return loginSuccess;
        }
    }

}