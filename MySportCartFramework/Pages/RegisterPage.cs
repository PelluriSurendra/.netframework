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
    // 1. Add all automatable controls in the page class
    // 2. Decorate findsBy attribute for all web elements
    // 3. Initialize the page

    class RegisterPage
    {        
        public RegisterPage(IWebDriver driver)
        {
            // Factory Design pattern

            // RegisterPage registerPage=new RegisterPage(driver);
            driver.Url = URLConstants.registerPageUrl;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.Id, Using = "firstname", Priority =1)]
        [FindsBy(How = How.Name, Using = "firstname", Priority = 2)]
        [FindsBy(How=How.XPath, Using = "//*[@class='field name-firstname']/descendant::input", Priority =3)]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "advice-required-entry-firstname", Priority = 1)]        
        [FindsBy(How = How.XPath, Using = ".//*[@class='field name-firstname']/div/div", Priority = 2)]
        public IWebElement lblErrorMessageFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastname", Priority = 1)]
        public IWebElement txtLastName { get; set; }

        public IWebElement lblErrorMessageLastName { get; set; }

        [FindsBy(How = How.Id, Using = "email_address", Priority = 1)]
        public IWebElement txtEmail { get; set; }

        public IWebElement lblErrorMessageEmail { get; set; }

        public IWebElement chkSignUpForNewsLetter { get; set; }

        public IWebElement lblErrorMessageSignUpForNewsLetter { get; set; }

        [FindsBy(How = How.Id, Using = "password", Priority = 1)]
        public IWebElement txtPassword { get; set; }

        public IWebElement lblErrorPassword { get; set; }

        [FindsBy(How = How.Id, Using = "confirmation", Priority = 1)]
        public IWebElement txtConfirmPassword { get; set; }

        public IWebElement lblErrorMessageConfirmPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@title='Submit']", Priority = 1)]
        public IWebElement btnSubmit { get; set; }

        public IWebElement btnBack { get; set; }
    }    
}
