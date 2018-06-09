using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySportCartFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportCartFramework.Testcases
{
    [TestClass]
    public class TestBase
    {
        protected IWebDriver driver;
        private TestContext testContext;
        private DesiredCapabilities desiredCapabilities;

        protected ExtentTest test;

        private static ExtentReports extentReports;
        public static string reportName;
        protected SelectElement selectElement;
        protected Actions actions;
        protected WebDriverWait wait;


        public TestContext TestContext
        { 
            set { testContext = value; }
            get { return testContext; }
        }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            reportName = "Report " + Guid.NewGuid() + ".html";
            extentReports = new ExtentReports(reportName);            
            extentReports.LoadConfig("ExtentReports-config.xml");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            test = extentReports.StartTest(TestContext.TestName);
            test.Log(LogStatus.Info, "Test case execution began - "+DateTime.Now.ToString());
            string browser = ConfigurationManager.AppSettings["browser"].ToString().ToLower();
            
            switch (browser)
            {
                case "firefox":
                    FirefoxProfile firefoxProfile = new FirefoxProfile();
                    firefoxProfile.AcceptUntrustedCertificates = true;
                    // driver = new FirefoxDriver(firefoxProfile);
                    desiredCapabilities = DesiredCapabilities.Firefox();
                    // desiredCapabilities.SetCapability()
                    desiredCapabilities.Platform = new Platform(PlatformType.Any);
                    test.Log(LogStatus.Info, "Launching firefox browser");
                    break;
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true,true);
                    driver = new ChromeDriver(chromeOptions);

                    test.Log(LogStatus.Info, "Launching chrome browser");
                    break;
                case "ie":
                    var ieOptions = new InternetExplorerOptions();
                    ieOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true);
                    driver = new InternetExplorerDriver(ieOptions);

                    test.Log(LogStatus.Info, "Launching internet explorer browser");
                    break;
                default:
                    test.Log(LogStatus.Fatal, "No valid browser selected");
                    break;
            }
           // driver = new RemoteWebDriver(new Uri("http://192.168.0.101:4444/wd/hub"), desiredCapabilities);
          //  EventFiringWebDriver eventFiringWebDriver = new EventFiringWebDriver(driver);
            //eventFiringWebDriver.ExceptionThrown += EventFiringWebDriver_ExceptionThrown;
            //driver = eventFiringWebDriver;
            //test.Log(LogStatus.Info, "Attached exception event handler");

            driver.Manage().Window.Maximize();
            test.Log(LogStatus.Info, "Browser maximized ");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(60));

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            driver.Url = ConfigurationManager.AppSettings["url"].ToString();
            // driver.Url = "http://ankpro.com";
            test.Log(LogStatus.Info, "Navigated to base url");
        }

        private void EventFiringWebDriver_ExceptionThrown(object sender, WebDriverExceptionEventArgs e)
        {
            test.Log(LogStatus.Fail, "Exception thrown : " + e.ThrownException.Message);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(TestContext.TestName + ".png", ImageFormat.Png);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
        }

        [AssemblyCleanup]
        public static void AssemblyCleanUp()
        {
            extentReports.Flush();
            string mailIds = ConfigurationManager.AppSettings["mailids"].ToString();
            string mailSubject = ConfigurationManager.AppSettings["mailsubject"].ToString();
           // Mailer.SendMail(mailIds,mailSubject, "<b><i>Check out test report<i><b>", reportName);
        }        
    }
}
