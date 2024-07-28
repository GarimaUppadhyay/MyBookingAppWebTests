using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MyBookingWebAppTests.Objects
{
    public class AppointmentPageObjects
    {
        #region class members
        IWebDriver _driver;
        WebDriverWait _wait;
        #endregion

        #region Constructor

        /// <summary>
        /// Construcror for Appointment Page Object class
        /// </summary>
        /// <param name="wait"></param>
        /// <param name="webDriver"></param>
        public AppointmentPageObjects(WebDriverWait wait, IWebDriver webDriver)
        {
            _wait = wait;
            _driver = webDriver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
        #endregion
        #region Class Properties

        public IWebElement NewAppointmentButton
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.NewAppointmentButton)));

            }
        }
        public IWebElement UserNameField
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.UserNameField)));

            }
        }
          public IWebElement AppointmentName
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.AppointmentName)));

            }
        }
        public IWebElement AppointmentDate
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.AppointmentDate)));

            }
        }
        public IWebElement AppointmentTime
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.AppointmentTime)));

            }
        }

         public IWebElement SaveButton
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.SaveButton)));

            }
        }

         public IWebElement CancelButton
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.CancelButton)));

            }
        }
        public IWebElement SuccessMessageLabel
        {
            get
            {
                return _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                    ElementExists(By.Id(AppointmentPageLocators.SuccessMessageLabel)));

            }
        }
        #endregion
    }
    public static class AppointmentPageLocators
    {
        public static string NewAppointmentButton = "AppButton_ID";
        public static string UserNameField = "UserName_ID";
        public static string AppointmentName= "AppNameField_ID";
        public static string AppointmentDate = "DateField_ID";
        public static string AppointmentTime = "TimeField_ID";
        public static string SaveButton = "SaveButton_ID";
        public static string CancelButton = "CancelButton_ID'";
        public static string SuccessMessageLabel = "SuccessMsgLabel_ID'";
    }
    
}