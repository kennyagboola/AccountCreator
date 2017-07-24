using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RegisterOnGoogle
{
 public   class GmailRegistrationConfirmationPage
    {
        private readonly IWebDriver _driver;
        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement _firstName;
        

        public GmailRegistrationConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public string FirstName => _firstName.Text;

    }
}
