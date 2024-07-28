using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MyBookingWebAppTests.Objects;
using MyBookingWebAppTests.Helper;

namespace MyBookingWebAppTests.Pages
{
    public class AppointmentPage
    {
        #region Class members
        WebDriverWait _wait;
        IJavaScriptExecutor executor;
        IWebDriver _driver;
        TestContext _testContext;
        AppointmentPageObjects appointmentPageObject;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for AppointmentPage
        /// </summary>
        /// <param name="wait"></param>
        /// <param name="driver"></param>
        /// <param name="testContext"></param>
        public AppointmentPage(WebDriverWait wait, IWebDriver driver, TestContext testContext)
        {
            _wait = wait;
            executor = (IJavaScriptExecutor)driver;
            _driver = driver;
            _testContext = testContext;
            appointmentPageObject = new AppointmentPageObjects(_wait, _driver);
        }


        #endregion

       /// <summary>
       /// Method for making new appointments
       /// </summary>
       /// <param name="title"></param>
       /// <param name="date"></param>
       /// <param name="time"></param>
       /// <returns></returns>
        public bool BookNewAppointment(string title, string date, string time)
        {
            bool bookingSuccess = true;
            try
            {
                appointmentPageObject.NewAppointmentButton.Click();
                //as this is dry run, we can include waits based on the element visibilty on pop up
                appointmentPageObject.AppointmentName.SendKeys(title);
                appointmentPageObject.AppointmentDate.SendKeys(date);
                appointmentPageObject.AppointmentTime.SendKeys(time);
                appointmentPageObject.SaveButton.Click();
                CommonUtilities.CaptureScreenshot("NewAppointment", _driver, _testContext);
            }
            catch (Exception e)
            {
                bookingSuccess = false;
                _testContext.WriteLine("Error while making appointment", e.Message);
                CommonUtilities.CaptureScreenshot("ErrorNewAppointment", _driver, _testContext);
            }
            return bookingSuccess;
        }

       /// <summary>
       /// This method compare the value added for new appointment and compare if it saved correctly
       /// </summary>
       /// <param name="appTitle"></param>
       /// <param name="successMsg"></param>
       /// <returns></returns>
        public bool ValidateBookingSaved(string appTitle,string successMsg)
        {
            bool bookingSuccess = true;
            try
            {
                bookingSuccess &= appointmentPageObject.SuccessMessageLabel.GetAttribute("innerText").ToLower().Contains(successMsg.ToLower());
                bookingSuccess &= appointmentPageObject.AppointmentName.GetAttribute("innerText").ToLower().Contains(appTitle.ToLower());
                CommonUtilities.CaptureScreenshot("BookingSaved", _driver, _testContext);
            }
            catch (Exception e)
            {
                bookingSuccess = false;
                _testContext.WriteLine("Error while Saving booking", e.Message);
                CommonUtilities.CaptureScreenshot("ErrorBookingSaved", _driver, _testContext);
            }
            return bookingSuccess;
        }
    }
}