using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship1.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {

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


        }
    }
}
