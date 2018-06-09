using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySportCartFramework.Pages
{
    class MyDashboardPage
    {
        public MyDashboardPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.XPath, Using = ".//h4[text()='Default Billing Address']/../address/./a[text()='Edit Address']", Priority =1)]
        public IWebElement lnkBillingAddress { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h4[text()='Default Shipping Address']/../address/./a[text()='Edit Address']", Priority = 1)]
        public IWebElement lnkShippingAddress { get; set; }
    }
}
