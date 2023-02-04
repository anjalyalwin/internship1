
using internship1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;





//open chrome browser

IWebDriver driver = new ChromeDriver();

// Login page object Initialization and definition

LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginActions(driver);

// LanguagePage object Initialization and definition

LanguagePage languagePageObj = new LanguagePage();
languagePageObj.Language(driver);

// Skillspage Object Initialization and definition

SkillsPage SkillsPageObj = new SkillsPage();
SkillsPageObj.Skills(driver);

// EducationPage Object Initialization and definition

EducationPage EducationPageobj= new EducationPage();
EducationPageobj.Education(driver);

// Certification page object Intialization and definition
 
CertificationPage CertificationPageObj= new CertificationPage();
CertificationPageObj.Certification(driver);






