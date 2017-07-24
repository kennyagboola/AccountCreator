using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using NUnit;


namespace RegisterOnGoogle
{
   
    public class RegisterOnGooglePage


    {
       
        private readonly IWebDriver _driver;
        
        const string PageUri = @"http://www.google.co.uk/";
     

       
        [FindsBy(How = How.Name, Using = "FirstName")]
        private IWebElement _firstName;

        [FindsBy(How = How.Name, Using = "LastName")]
        private IWebElement _secondName;
        [FindsBy(How = How.Name, Using = "GmailAddress")]
        private IWebElement _gmailaddress;

        [FindsBy(How = How.Name, Using = "Passwd")]
        private IWebElement _passwd;

        [FindsBy(How = How.Name, Using = "PasswdAgain")]
        private IWebElement _passwdagain;
        
        [FindsBy(How = How.Name, Using = "BirthDay")]
        private IWebElement _birthday;

        [FindsBy(How = How.Name, Using = "BirthYear")]
        private IWebElement _birthyear;
        [FindsBy(How = How.Name, Using = "RecoveryPhoneNumber")]
        private IWebElement _recoveryphonenumber;
         [FindsBy(How = How.XPath, Using = "//div[@aria-activedescendant=':d']")]
        private IWebElement _gender;
        [FindsBy(How = How.XPath, Using = "//div[@role='listbox']")]
        private IWebElement _birthmonth;
        [FindsBy(How = How.Name, Using = "RecoveryEmailAddress")]
        private IWebElement _emailadd;

        [FindsBy(How = How.Name, Using = "submitbutton")]
        private IWebElement _submitbutton;
        [FindsBy(How = How.Id, Using = "tos-scroll-button")]
        private IWebElement _tosscrollbutton;
        [FindsBy(How = How.Name, Using = "iagreebutton")]
        private IWebElement _iagreebutton;
        [FindsBy(How = How.Id, Using = "errormsg_0_GmailAddress")]
        private IWebElement _errorText;

        [FindsBy(How = How.XPath, Using = "//*[@id='view_container']/form/div[2]/div/div[2]/div[2]")]
        private IWebElement _moreoptionclick;

        [FindsBy(How = How.Id, Using = "SIGNUP")]
        private IWebElement _createaccount;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign in')]")]
        private IWebElement _signinclick;
        [FindsBy(How = How.XPath, Using = "//*[@id='profileIdentifier']")]

        private IWebElement _accountheadingText;
        [FindsBy(How = How.Id, Using = "passwordNext")]
        private IWebElement _passwordnextclick;
        [FindsBy(How = How.Id, Using = "identifierNext")]
        private IWebElement _nextclick;
        [FindsBy(How = How.LinkText, Using = "Sign out")]
        private IWebElement _linktestsignout;
        [FindsBy(How = How.XPath, Using = "//*[@id='gb']/div[1]/div[1]/div[2]/div[4]/div[1]/a")]
        
        private IWebElement _googleaccountbuttonclick;  
        [FindsBy(How = How.XPath, Using = "//*[@id='gbw']/div/div/div[1]/div[2]/a")]
        private IWebElement _gmailbuttonclick;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign in')]")]
        private IWebElement _textcontainsigninclick;

        [FindsBy(How = How.Id, Using = "gbw")]
        private IWebElement _accounttext;

        public RegisterOnGooglePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            
        }

        
         public static RegisterOnGooglePage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);

            return new RegisterOnGooglePage(driver);
        }

        //implicit wait
        public static void ImplicitWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        //Explicitly wait
        public void WaitBeforeClick(IWebDriver parent, By by, int counter)

        {
            bool Displayed = false;

            for (int v = 0; v < counter; counter++)
            {
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                    wait.Until((d) => { return parent.FindElement(by); });

                    Displayed = parent.FindElement(by).Displayed;

                    if (Displayed)
                    {
                        parent.FindElement(by).Click();
                        break;
                    }
                }
                catch
                {
                }
            }
        }





        public string FirstName
        {
            set
            {
                _firstName.SendKeys(value);
            }
        }

        public string SecondName
        {
            set
            {
                _secondName.SendKeys(value);
            }
        }
        public string GmailAddress
        {
            set
            {
                _gmailaddress.SendKeys(value);
            }
        }
        public string Passwd
        {
            set
            {
                _passwd.SendKeys(value);
            }
        }

        public string PasswdAgain
        {
            set
            {
                _passwdagain.SendKeys(value);
            }
        }
        
        public string BirthMonth
        {
            set
            {
                _birthmonth.SendKeys(value);
            }
        }
        public string BirthDay
        {
            set
            {
                _birthday.SendKeys(value);
            }
        }
        public string BirthYear
        {
            set
            {
                _birthyear.SendKeys(value);
            }
        }

        public string RecoveryPhoneNumber
        {
            set
            {
                _recoveryphonenumber.SendKeys(value);
            }
        }
        public string EmailAdd
        {
            set
            {
                _emailadd.SendKeys(value);
            }
        }

        public string Gender
        {
            set
            {
                _gender.SendKeys(value);
            }
        }
     
        public string ErrorText => _errorText.Text;

        public void ToScrollButton()
        {
            
            _tosscrollbutton.Click();
        }
        public void CreateAccount()
        {

            _createaccount.Click();
        }
        public void MoreOptionsClick()
        {

            _moreoptionclick.Click();
        }
        public void SignInClick()
        {

            _signinclick.Click();
        }

        public void passwordClick()
        {
            _gmailaddress.Click();
           
        }
        public void IAgreeButton()
        {
            _iagreebutton.Click();
        }
        public void EmptyEnterPasswd()
        {
            
                _passwd.SendKeys(Keys.Return);
           
        }
        public string logoutResult => _accountheadingText.Text;
        public string AccountText => _accounttext.Text;
        public void PasswordNextclick()
        {
            _passwordnextclick.Click();
        }
        public void TheNextButtonClick()
        {
            _nextclick.Click();
        }
        public void TheSignInButton()
        {
            _textcontainsigninclick.Click();
        }
        public void LinkTestSignout()
        {
            _linktestsignout.Click();
        }
        public void _GmailButtonclick()
        {
            _gmailbuttonclick.Click();
        }
        public void GoogleAccountButtonClick()
        {
            _googleaccountbuttonclick.Click();
        }
       

        public GmailRegistrationConfirmationPage SubmitClick()
        {
            System.Threading.Thread.Sleep(5000);

            _submitbutton.Click();

            return new GmailRegistrationConfirmationPage(_driver);
        }

        public static void EnterTest(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);


        }
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

     
    }
}
