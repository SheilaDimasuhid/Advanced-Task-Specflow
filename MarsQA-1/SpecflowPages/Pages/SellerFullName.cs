using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class SellerFullName
    {                   
            private IWebElement fnDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            private IWebElement firstName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            private IWebElement lastName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            private IWebElement saveBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            private IWebElement combinedName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
        
        public void navigateDropDown()
        {
            fnDropdownBtn.Click();
        }

        public void SetFirstname (string fName)
        {
            Thread.Sleep(1000);
            firstName.Clear();
            firstName.SendKeys(fName);
        }

        public void SetLastname(string lName)
        {
            Thread.Sleep(1000);
            lastName.Clear();
            lastName.SendKeys(lName);
        }

        public string GetFirstname()
        {
            Thread.Sleep(1000);
            return firstName.Text;
        }
        public string GetLastname()
        {
            Thread.Sleep(1000);
            return lastName.Text;
        }

        public void SaveFullName()
        {
            saveBtn.Click();
        }

        public void CheckFullname(string fullname)
        {
            Thread.Sleep(2000);
            Assert.That(fullname.Equals(combinedName.Text), "FullName do not match");
        }

    }
}
