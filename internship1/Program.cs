
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



//open chrome browser

IWebDriver driver = new ChromeDriver();

//launch local host
driver.Navigate().GoToUrl("http://localhost:5000/Home");

//login to local host
IWebElement SigninTextbox = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
SigninTextbox.Click();
IWebElement EmailId = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
EmailId.SendKeys("anjalyalwin123@gmail.com");
IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
Password.SendKeys("Abraham123");
IWebElement SigninButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
SigninButton.Click();
Thread.Sleep(1000);

//click profile botton
IWebElement Profilebotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
Profilebotton.Click();

//click on Language botton and add details
IWebElement Languagebotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
Languagebotton.Click();

IWebElement Addbotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
Addbotton.Click();
Thread.Sleep(500);

IWebElement AddLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
AddLanguage.SendKeys("Hindi");

IWebElement ChooseLanguagebotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
ChooseLanguagebotton.Click();
Thread.Sleep(1000);

IWebElement BasicBotton = driver.FindElement(By.XPath("//option[@value='Basic']"));
BasicBotton.Click();

IWebElement AddBotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
AddBotton.Click();
Thread.Sleep(500);

IWebElement Addbotton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
Addbotton1.Click();


IWebElement AddLanguage1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
AddLanguage1.SendKeys("English");

IWebElement ChooseLanguagebotton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
ChooseLanguagebotton1.Click();
Thread.Sleep(1000);

IWebElement Fluentbotton = driver.FindElement(By.XPath("//option[@value='Fluent']"));
Fluentbotton.Click();
Thread.Sleep(1000);

IWebElement Addbotton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
Addbotton2.Click();
Thread.Sleep(1000);





