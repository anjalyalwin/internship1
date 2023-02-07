using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internship1.Pages
{
    public class CertificationPage
    {
        public void Certification(IWebDriver driver)
        {
            //click on certification and add details

            IWebElement CertificationBotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationBotton.Click();

            IWebElement AddCertificationBotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            AddCertificationBotton.Click();

            IWebElement Certification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            Certification.SendKeys("MCSE");

            IWebElement Certifiedfrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            Certifiedfrom.SendKeys("Microsoft");

            IWebElement Certifiedyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            Certifiedyear.Click();

            IWebElement SelectCertifiedyear = driver.FindElement(By.XPath("//option[@value='2022']"));
            SelectCertifiedyear.Click();

            IWebElement CertificationAddBotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            CertificationAddBotton.Click();

            driver.Quit();

        }

    }
}
