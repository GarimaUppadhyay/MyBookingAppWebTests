using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using MyBookingWebAppTests.Pages;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyBookingWebAppTests.StepDefinitions
{
    [Binding]
    public class UserAppointmentSteps
    {
        BasePage basePage;
        IWebDriver driver;
        public UserAppointmentSteps(ScenarioContext context)
        {
            basePage = context["AUT"] as BasePage;
            driver = context["WEB_DRIVER"] as IWebDriver;
        }

        [Given(@"User navigates to Login screen")]
        public void GivenUserNavigatesToLoginScreen()
        {
            //Include url for Booking site to navigate
        }

        [Given(@"User enters TestId@test\.com and Test(.*) and clicks Login")]
        public void GivenUserEntersTestIdTest_ComAndTestAndClicksLogin(string username, string password)
        {
            Assert.IsTrue(basePage.LoginPage.ValidateUserLogin(username, password));
        }

        [Then(@"User Should successfully navigates to booking screen")]
        public void ThenUserShouldSuccessfullyNavigatesToBookingScreen()
        {
            // compare page navigation code
        }


        [Then(@"Enter new Appointment Details with Sprint Planning (.*)(.*):(.*)am and Click save")]
        public void ThenEnterNewAppointmentDetailsWithSprintPlanningAmAndClickSave(string appTitle, string date, string time)
        {
            Assert.IsTrue(basePage.AppointmentPage.BookNewAppointment(appTitle, date,time));
        }

        [Then(@"Validate Appointment details should be visible after saving with success Appointment Saved!")]
        public void ThenValidateAppointmentDetailsShouldBeVisibleAfterSavingWithSuccessAppointmentSaved(string appTitle,string message)
        {
            Assert.IsTrue(basePage.AppointmentPage.ValidateBookingSaved(appTitle, message));
        }

    }
}