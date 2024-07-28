using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBookingWebAppTests.Helper
{
    /// <summary>
    /// Class for handling reusable functions
    /// </summary>
    public static class  CommonUtilities
    {
        /// <summary>
        /// Method for Capturing screen and saving it with given name 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="driver"></param>
        /// <param name="testContext"></param>
        public static void CaptureScreenshot(string fileName, IWebDriver driver, TestContext testContext)
        {
            Random random = new Random();
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            fileName = fileName + "_" + random.Next();
            string screenshotFile = Path.Combine(fileName + "_screenshot.png");
            screenshot.SaveAsFile(screenshotFile);
            testContext.AddResultFile(screenshotFile);
        }
    }
}