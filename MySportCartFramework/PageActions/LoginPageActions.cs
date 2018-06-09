using MySportCartFramework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportCartFramework.PageActions
{
    static class LoginPageActions
    {
        public static void Login(IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            // TODO: Doing this because we are yet to understand how to read app.config
            loginPage.txtEmail.SendKeys("abc@abc.com"); // Should taken from app.config file
            loginPage.txtPassword.SendKeys("123456");
            loginPage.btnLogin.Click();
        }
    }
}
