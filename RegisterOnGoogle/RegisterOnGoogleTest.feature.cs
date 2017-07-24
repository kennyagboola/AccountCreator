﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RegisterOnGoogle
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GmailRegistration")]
    public partial class GmailRegistrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RegisterOnGoogleTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GmailRegistration", "\t\t In order to have a gmail account \r\n\t\t As a user\r\n\t\t I want to be able to creat" +
                    "e a gmail account", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successful Register with valid account")]
        public virtual void SuccessfulRegisterWithValidAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successful Register with valid account", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
   testRunner.Given("a user is on Google page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
   testRunner.And("the user navigate to account creation site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Firstname",
                        "secondname",
                        "username",
                        "password",
                        "confpassword",
                        "birthdaym",
                        "birthdayd",
                        "birthdayy",
                        "gender",
                        "phone",
                        "emailadd"});
            table1.AddRow(new string[] {
                        "pebbles",
                        "sheki",
                        "445rer12345",
                        "9056qw0www",
                        "9056qw0www",
                        "July",
                        "27",
                        "1994",
                        "female",
                        "7333563222",
                        "saee@hotmail.com"});
#line 10
  testRunner.When("the User enter credentials", ((string)(null)), table1, "When ");
#line 13
  testRunner.And("The user clicks on the nextstep button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
   testRunner.And("The user click on the scroll button that appears on Privacy and Terms message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
     testRunner.And("The user click on the scroll button that appears on Privacy and Terms message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
   testRunner.And("The user clicks on the I agree button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.And("The welcome page appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
   testRunner.And("The user clicks on the continue button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
   testRunner.Then("a Valid registered account appears with account email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register with Invalid Account")]
        [NUnit.Framework.TestCaseAttribute("Shawn", "Bravo", "bolatony12_", null)]
        public virtual void RegisterWithInvalidAccount(string firstname, string secondname, string username, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register with Invalid Account", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
   testRunner.Given("a user is on Google page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
   testRunner.And("the user navigate to account creation site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.When(string.Format("the User enter credentials {0}, {1} and {2}", firstname, secondname, username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
  testRunner.And("the user click on create password box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("the user should see an error message telling the user (Please use only letters (a" +
                    "-z), numbers, and periods)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successful Login and Logout with Valid Credentials")]
        public virtual void SuccessfulLoginAndLogoutWithValidCredentials()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successful Login and Logout with Valid Credentials", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
   testRunner.Given("a user is on Google page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
   testRunner.And("the user click on the sign in button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
   testRunner.And("the user enter a valid username bolatony1234", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
   testRunner.And("the user click on the next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
   testRunner.And("the user enter a valid password 7890wwww", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
   testRunner.When("the user click on the next button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
   testRunner.And("the user click on the gmail button on the welcome page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
   testRunner.And("the user click on the google account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
   testRunner.When("the user click on the sign out button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
   testRunner.Then("the user should be logout successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
