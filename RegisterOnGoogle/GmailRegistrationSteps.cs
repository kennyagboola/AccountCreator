using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
    
namespace RegisterOnGoogle
{
   

    [Binding]
   
    public class GmailRegistrationSteps
    {
       
        private IWebDriver _driver;
        
        private RegisterOnGooglePage _registrationPage;
        private GmailRegistrationConfirmationPage _confirmation;
        private GoogleRegistrationDetail _registrationdetail;
        private string _user;


     
        [Given(@"a user is on Google page")]
        public void GivenAUserIsOnGooglePage()
        {
            _driver = new FirefoxDriver();
            
            _driver.Manage().Window.Maximize();
            _registrationPage = RegisterOnGooglePage.NavigateTo(_driver);
            RegisterOnGooglePage.ImplicitWait(_driver);


        }
        [Given(@"the user navigate to account creation site")]
        public void GivenTheUserNavigateToAccountCreationSite()
        {
            _registrationPage.SignInClick();
            _registrationPage.MoreOptionsClick();
             System.Threading.Thread.Sleep(5000);
            _registrationPage.CreateAccount();
        
        }


        [When(@"the User enter credentials")]
        public void WhenTheUserEnterCredentials(Table table)
        {
            
            GoogleRegistrationDetail detail = table.CreateInstance<GoogleRegistrationDetail>();
          
            _registrationPage.FirstName =  detail.FirstName;
            _registrationPage.SecondName= detail.SecondName;
            _registrationPage.GmailAddress = detail.Username;
            _registrationPage.Passwd= detail.Password;
            _registrationPage.PasswdAgain = detail.Confpassword;
            _registrationPage.BirthMonth = detail.BirthdayM;
            _registrationPage.BirthDay = detail.BirthdayD;
            _registrationPage.BirthYear = detail.BirthdayY;
            _registrationPage.Gender = detail.Gender;
            _registrationPage.RecoveryPhoneNumber= detail.Phone;
            _registrationPage.EmailAdd = detail.EmailAdd;
            _user = (detail.Username +"" + "@gmail.com").Trim();


        }

        [When(@"The user clicks on the nextstep button")]
        public void WhenTheUserClicksOnTheNextstepButton()
        {
            _confirmation = _registrationPage.SubmitClick();

        }

        [When(@"The user click on the scroll button that appears on Privacy and Terms message")]
        public void WhenTheUserClickOnTheScrollButtonThatAppearsOnPrivacyAndTermsMessage()
        {
           
            _registrationPage.ToScrollButton();
        }
        
        [When(@"The user clicks on the I agree button")]
        public void WhenTheUserClicksOnTheIAgreeButton()
        {
            _registrationPage.IAgreeButton();
        }
        
        [When(@"The welcome page appears")]
        public void WhenTheWelcomePageAppears()
        {
           // System.Threading.Thread.Sleep(5000);
        }
        
        [When(@"The user clicks on the continue button")]
        public void WhenTheUserClicksOnTheContinueButton()
        {

            _confirmation = _registrationPage.SubmitClick();
        }
        
        [Then(@"a Valid registered account appears with account email")]
        public void ThenAValidRegisteredAccountAppearsWithAccountEmail()
        {
            _registrationPage.WaitBeforeClick(_driver, By.Id("gbw"), 10);

            Assert.IsTrue(_registrationPage.AccountText.Contains(_user));
       
            
            
        }
        [When(@"the User enter credentials (.*), (.*) and (.*)")]
        public void WhenTheUserEnterCredentials(string firstname, string secondname, string username)
        {

           // GoogleRegistrationDetail detail = new GoogleRegistrationDetail();

          _registrationPage.FirstName=firstname;
            _registrationPage.SecondName = secondname;
            _registrationPage.GmailAddress = username;
           
        }


     
        [When(@"the user click on create password box")]
        public void WhenTheUserClickOnCreatePasswordBox()
        {
          //  _driver.FindElement(By.Id("Passwd")).SendKeys(Keys.Return);

          _registrationPage.EmptyEnterPasswd();
           

        }

        [Then(@"the user should see an error message telling the user \(Please use only letters \(a-z\), numbers, and periods\)")]
        public void ThenTheUserShouldSeeAnErrorMessageTellingTheUserPleaseUseOnlyLettersA_ZNumbersAndPeriods()
        {
           

             _registrationPage.WaitBeforeClick(_driver, By.Id("errormsg_0_GmailAddress"), 10);
            
          Assert.IsNotEmpty(_registrationPage.ErrorText);
         




        }
        [Given(@"the user click on the sign in button")]
        public void GivenTheUserClickOnTheSignInButton()
        {
            // _driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]")).Click();
            _registrationPage.TheSignInButton();
        }

        [Given(@"the user enter a valid username(.*)")]
        public void GivenTheUserEnterAValidUsername(string username)
        {

           // _driver.FindElement(By.Id("identifierId")).SendKeys(username);
           
            RegisterOnGooglePage.EnterTest(_driver, "identifierId", username, "Id");
            _user = (username + "" + "@gmail.com").Trim();
          
        }

        [Given(@"the user click on the next button")]
        public void GivenTheUserClickOnTheNextButton()
        {
            //_driver.FindElement(By.Id("identifierNext")).Click();

            _registrationPage.TheNextButtonClick();
          
            System.Threading.Thread.Sleep(5000);
        }

        [Given(@"the user enter a valid password(.*)")]
        public void GivenTheUserEnterAValidPassword(string password)
        {
           // _registrationPage.WaitBeforeClick(_driver, By.Id("password"), 10);

            RegisterOnGooglePage.EnterTest(_driver, "password", password, "Id");


        }

        [When(@"the user click on the next button")]
        public void WhenTheUserClickOnTheNextButton()
        {
            //_driver.FindElement(By.Id("passwordNext")).Click();
            _registrationPage.PasswordNextclick();
        }

        [When(@"the user click on the gmail button on the welcome page")]
        public void WhenTheUserClickOnTheGmailButtonOnTheWelcomePage()
        {
           // _driver.FindElement(By.XPath("//*[@id='gbw']/div/div/div[1]/div[2]/a")).Click();
            _registrationPage._GmailButtonclick();
          
        }

        [When(@"the user click on the google account button")]
        public void WhenTheUserClickOnTheGoogleAccountButton()
        {
            // _driver.FindElement(By.XPath("//*[@id='gb']/div[1]/div[1]/div[2]/div[4]/div[1]/a")).Click();
            _registrationPage.GoogleAccountButtonClick();
            
        }

        [When(@"the user click on the sign out button")]
        public void WhenTheUserClickOnTheSignOutButton()
        {
            //_driver.FindElement(By.LinkText("Sign out")).Click();
            _registrationPage.LinkTestSignout();
            
        }

        [Then(@"the user should be logout successfully")]
        public void ThenTheUserShouldBeLogoutSuccessfully()
        {
           
             Assert.IsTrue(_registrationPage.logoutResult.Contains(_user ));

            //ScenarioContext.Current.Pending();
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }

    }



}

