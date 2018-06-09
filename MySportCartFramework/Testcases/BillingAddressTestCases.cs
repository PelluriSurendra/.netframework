using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySportCartFramework.PageActions;
using MySportCartFramework.Pages;
using MySportCartFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySportCartFramework.Testcases
{
    [TestClass]
    public class BillingAddressTestCases:TestBase
    {
        [TestMethod]
        public void ChangeCountryInBillingAddress()
        {
            LoginPageActions.Login(driver);
            test.Log(LogStatus.Info, "Logged in successfully");

            MyDashboardPage myDashboardPage = new MyDashboardPage(driver);
            myDashboardPage.lnkBillingAddress.Click();
            test.Log(LogStatus.Info, "Clicked on billing address link successfully");

            AddNewAddressPage addNewAddressPage = new AddNewAddressPage(driver);

            addNewAddressPage.txtStreetAddress1.SendKeys(RandomNumberAndStringGenerator.GenerateRandomString(false, 20));
            test.Log(LogStatus.Info, "Street addres 1 updated from random string generator class");

            addNewAddressPage.txtStreetAddress2.SendKeys(RandomNumberAndStringGenerator.GenerateRandomString(false, 20));
            test.Log(LogStatus.Info, "Street addres 2 updated from random string generator class");

            addNewAddressPage.txtCity.SendKeys(RandomNumberAndStringGenerator.GenerateRandomString(true, 25));
            test.Log(LogStatus.Info, "City updated from random string generator class");

            addNewAddressPage.txtState.SendKeys(RandomNumberAndStringGenerator.GenerateRandomString(true, 25));
            test.Log(LogStatus.Info, "State updated from random string generator class");

            addNewAddressPage.txtZipCode.SendKeys(RandomNumberAndStringGenerator.GenerateRandomNumber(100000,999999).ToString());
            test.Log(LogStatus.Info, "Zip code updated from random string generator class");

            selectElement = new SelectElement(addNewAddressPage.ddCountry);
            selectElement.SelectByText("Bhutan");
            test.Log(LogStatus.Info, "Bhutan country selected successfully");

            // This is how we handle ajax calls 
            // wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("")));

            test.Log(LogStatus.Pass, TestContext.TestName + " is passed.");
        }
    }
}
