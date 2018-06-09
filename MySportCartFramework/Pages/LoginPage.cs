using MySportCartFramework.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportCartFramework.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            driver.Url = URLConstants.loginPageUrl;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How =How.Id, Using ="email", Priority =1)]
        [FindsBy(How = How.Name, Using = "login[username]", Priority = 2)]
        [FindsBy(How = How.XPath, Using = "//*[@title='Email Address']", Priority = 3)]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "pass", Priority = 1)]        
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "send2", Priority = 1)]
        public IWebElement btnLogin { get; set; }
    }
}
