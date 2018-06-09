using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySportCartFramework.Pages;
using RelevantCodes.ExtentReports;
using System;
/// <summary>
/// This test class is used for registration page test cases
/// </summary>
namespace MySportCartFramework.Testcases
{
    [TestClass]
    public class RegistrationPageTestCases:TestBase
    {
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\suren\Downloads\MySportCartFramework New\MySportCartFramework\bin\Debug\registerationData.csv",
            "registerationData#csv",
            DataAccessMethod.Sequential)]
        [DeploymentItem("registerationData.csv")]
        [TestMethod]
        public void VerifyValidRegistrationViaDataDriverUsingCSV()
        {   
            RegisterPage registerPage = new RegisterPage(driver);
            test.Log(LogStatus.Info, "Navigated to Register page successfully");
            
            registerPage.txtFirstName.SendKeys(TestContext.DataRow[0].ToString());
            test.Log(LogStatus.Info, "First name entered successfully");

            registerPage.txtLastName.SendKeys(TestContext.DataRow[1].ToString());
            test.Log(LogStatus.Info, "Last name entered successfully");

            registerPage.txtEmail.SendKeys(Guid.NewGuid()+TestContext.DataRow[2].ToString());
            test.Log(LogStatus.Info, "Email entered successfully");

            registerPage.txtPassword.SendKeys(TestContext.DataRow[3].ToString());
            test.Log(LogStatus.Info, "Password entered successfully");

            registerPage.txtConfirmPassword.SendKeys(TestContext.DataRow[4].ToString());
            test.Log(LogStatus.Info, "Confirm Password entered successfully");

            registerPage.btnSubmit.Click();
            test.Log(LogStatus.Info, "Submit button clicked successfully");
            
            Assert.AreEqual("My Account", driver.Title);
            test.Log(LogStatus.Pass, TestContext.TestName + " Test case has passed successfully");
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            @"C:\Users\suren\Downloads\MySportCartFramework New\MySportCartFramework\bin\Debug\registrationData.xml",
            "register",
            DataAccessMethod.Sequential)]
        [DeploymentItem("registrationData.xml")]
        [TestMethod]
        public void VerifyValidRegistrationViaDataDriverUsingXML()
        {
            RegisterPage registerPage = new RegisterPage(driver);
            test.Log(LogStatus.Info, "Navigated to Register page successfully");

            registerPage.txtFirstName.SendKeys(TestContext.DataRow["firstname"].ToString());
            test.Log(LogStatus.Info, "First name entered successfully");

            registerPage.txtLastName.SendKeys(TestContext.DataRow["lastname"].ToString());
            test.Log(LogStatus.Info, "Last name entered successfully");

            registerPage.txtEmail.SendKeys(Guid.NewGuid() + TestContext.DataRow["email"].ToString());
            test.Log(LogStatus.Info, "Email entered successfully");

            registerPage.txtPassword.SendKeys(TestContext.DataRow["password"].ToString());
            test.Log(LogStatus.Info, "Password entered successfully");

            registerPage.txtConfirmPassword.SendKeys(TestContext.DataRow["confirmpassword"].ToString());
            test.Log(LogStatus.Info, "Confirm Password entered successfully");

            registerPage.btnSubmit.Click();
            test.Log(LogStatus.Info, "Submit button clicked successfully");

            Assert.AreEqual("My Account", driver.Title);
            test.Log(LogStatus.Pass, TestContext.TestName + " Test case has passed successfully");
        }

        [DataSource("System.Data.SqlClient",
            "Server=.\\SQLEXPRESS;Database=TestDbNew;User Id=sa; Password=Ankpro01*;",
            "mysportcartnew",
            DataAccessMethod.Sequential)]      
        [TestMethod]
        public void VerifyValidRegistrationViaDataDriverUsingSQL()
        {
            RegisterPage registerPage = new RegisterPage(driver);
            test.Log(LogStatus.Info, "Navigated to Register page successfully");

            registerPage.txtFirstName.SendKeys(TestContext.DataRow["firstname"].ToString());
            test.Log(LogStatus.Info, "First name entered successfully");

            registerPage.txtLastName.SendKeys(TestContext.DataRow["lastname"].ToString());
            test.Log(LogStatus.Info, "Last name entered successfully");

            registerPage.txtEmail.SendKeys(Guid.NewGuid() + TestContext.DataRow["email"].ToString());
            test.Log(LogStatus.Info, "Email entered successfully");

            registerPage.txtPassword.SendKeys(TestContext.DataRow["password"].ToString());
            test.Log(LogStatus.Info, "Password entered successfully");

            registerPage.txtConfirmPassword.SendKeys(TestContext.DataRow["confirmpassword"].ToString());
            test.Log(LogStatus.Info, "Confirm Password entered successfully");

            registerPage.btnSubmit.Click();
            test.Log(LogStatus.Info, "Submit button clicked successfully");

            Assert.AreEqual("My Account", driver.Title);
            test.Log(LogStatus.Pass, TestContext.TestName + " Test case has passed successfully");
        }

        [DataSource("System.Data.Odbc",
            "Dsn=Excel Files;dbq=C:\\Users\\suren\\Downloads\\MySportCartFramework New\\MySportCartFramework\\bin\\Debug\\TestData\\registerationData.xlsx; Data Source=C:\\Users\\suren\\Downloads\\MySportCartFramework New\\MySportCartFramework\\bin\\Debug\\TestData\\registerationData.xlsx;defaultdir=.;Persist Security Info=False; ExtendedProperties='12.0;HDR=Yes'",
            "Data$",
            DataAccessMethod.Sequential)]
        [DeploymentItem("registerationData.xlsx")]
        [TestMethod]
        public void VerifyValidRegistrationViaDataDriverUsingExcel()
        {
            RegisterPage registerPage = new RegisterPage(driver);
            test.Log(LogStatus.Info, "Navigated to Register page successfully");

            registerPage.txtFirstName.SendKeys(TestContext.DataRow["firstname"].ToString());
            test.Log(LogStatus.Info, "First name entered successfully");

            registerPage.txtLastName.SendKeys(TestContext.DataRow["lastname"].ToString());
            test.Log(LogStatus.Info, "Last name entered successfully");

            registerPage.txtEmail.SendKeys(Guid.NewGuid() + TestContext.DataRow["email"].ToString());
            test.Log(LogStatus.Info, "Email entered successfully");

            registerPage.txtPassword.SendKeys(TestContext.DataRow["password"].ToString());
            test.Log(LogStatus.Info, "Password entered successfully");

            registerPage.txtConfirmPassword.SendKeys(TestContext.DataRow["confirmpassword"].ToString());
            test.Log(LogStatus.Info, "Confirm Password entered successfully");

            registerPage.btnSubmit.Click();
            test.Log(LogStatus.Info, "Submit button clicked successfully");

            Assert.AreEqual("My Account", driver.Title);
            test.Log(LogStatus.Pass, TestContext.TestName + " Test case has passed successfully");
        }
    }
}
