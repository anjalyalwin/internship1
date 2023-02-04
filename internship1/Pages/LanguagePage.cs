using internship1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship1.Pages
{
    public class LanguagePage

    {
        public void Language(IWebDriver driver)
        {
            //click on Language botton and add details
            IWebElement Languagebotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languagebotton.Click();

            IWebElement Addbotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            Addbotton.Click();

            Wait.WaitForElementTobeclicable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 5);

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
            Thread.Sleep(500);

            IWebElement AddLanguage1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage1.SendKeys("English");

            IWebElement ChooseLanguagebotton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLanguagebotton1.Click();

            Wait.WaitForElementTobeclicable(driver, "Xpath", "//option[@value='Fluent']", 5);


            IWebElement Fluentbotton = driver.FindElement(By.XPath("//option[@value='Fluent']"));
            Fluentbotton.Click();

            Wait.WaitForElementTobeclicable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 5);

            IWebElement Addbotton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            Addbotton2.Click();


        }
    }

}           
   


