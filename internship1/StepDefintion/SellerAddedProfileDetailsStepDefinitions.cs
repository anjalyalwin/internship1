using internship1.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace internship1.StepDefintion
{
    [Binding]
    public class SellerAddedProfileDetailsStepDefinitions
    {
        [Given(@"I logged into localhost successfully")]
        public void GivenILoggedIntoLocalhostSuccessfully()
        {
            IWebDriver driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Profile Page")]
        public void WhenINavigateToProfilePage()
        {
            IWebDriver driver = new ChromeDriver();
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.Language(driver);
        }

        [When(@"I added the profile details")]
        public void WhenIAddedTheProfileDetails()
        {
            IWebDriver driver = new ChromeDriver();
            SkillsPage SkillsPageObj = new SkillsPage();
            SkillsPageObj.Skills(driver);
            EducationPage EducationPageobj = new EducationPage();
            EducationPageobj.Education(driver);
            CertificationPage CertificationPageObj = new CertificationPage();
            CertificationPageObj.Certification(driver);

        }

        [Then(@"The profile details added successfully")]
        public void ThenTheProfileDetailsAddedSuccessfully()
        {
            
            
        }
    }
}
