using AventStack.ExtentReports;
using Keys_QA.Config;
using Keys_QA.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Keys_QA.Global
{
    public class Base
    {
        #region To access Path from resource file

        private static string BASE_PATH = Directory.GetParent(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
                .Parent.FullName;
        public static int Browser = int.Parse(Keys_Config.Browser);

        // Get the directory for the project, so you won't have to change the keys.resx file
        public static String ExcelPath = Path
            .Combine(BASE_PATH, Keys_Config.ExcelPath);

        public static string ScreenshotPath = Path.Combine(BASE_PATH, Keys_Config.ScreenShotPath);
        public static string ReportPath = Path.Combine(BASE_PATH, Keys_Config.ReportPath);

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

        #endregion
        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {

                case 1:
                    Driver.driver = new FirefoxDriver();
                    break;
                case 2:
                    Driver.driver = new ChromeDriver();
                    Driver.driver.Manage().Window.Maximize();
                    break;

            }
            if (Keys_Config.IsLogin == "true")
            {
                Login login = new Login();
                login.Successfull();
            }
            else
            {
                Register register = new Register();
                // navigate to registration page [need implementation]
            }
            // please use newest version of extent report [need implementation]
            //extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);

            //extent.LoadConfig(Keys_Resource.ReportXMLPath);
        }


        [TearDown]
        public void TearDown()
        {
            //// Screenshot [need implementation]
            //String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            //test.Log(LogStatus.Info, "Image example: " + img);
            //// end test. (Reports)
            //extent.EndTest(test);
            //// calling Flush writes everything to the log file (Reports)
            //extent.Flush();
            //// Close the driver :)            
            //Driver.driver.Close();
        }
        #endregion

    }
}
