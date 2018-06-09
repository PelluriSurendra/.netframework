using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportCartFramework.Pages
{
    class AddNewAddressPage
    {
        public AddNewAddressPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
                
        [FindsBy(How = How.Id, Using = "street_1", Priority = 1)]
        public IWebElement txtStreetAddress1 { get; set; }

        [FindsBy(How = How.Id, Using = "street_2", Priority = 1)]
        public IWebElement txtStreetAddress2 { get; set; }

        [FindsBy(How = How.Id, Using = "city", Priority = 1)]
        public IWebElement txtCity { get; set; }

        [FindsBy(How = How.Id, Using = "region", Priority = 1)]
        public IWebElement txtState { get; set; }

        [FindsBy(How = How.Id, Using = "zip", Priority = 1)]
        public IWebElement txtZipCode { get; set; }

        [FindsBy(How = How.Id, Using = "country", Priority = 1)]
        public IWebElement ddCountry { get; set; }

    }
}
