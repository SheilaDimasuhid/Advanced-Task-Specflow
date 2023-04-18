using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class SellerLanguages
    {
        private IWebElement languageTab => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));        
        private IWebElement addNewLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private IWebElement levelDropdownBtn => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        private IWebElement addLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private IWebElement cancelLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
        private IWebElement newlyAddedLanguageName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));        
        private IWebElement editLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
        private IWebElement updateLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

        private IWebElement newLanguageName => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));

        
        private IWebElement deleteLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));
        private IWebElement successNotification => Driver.driver.FindElement(By.XPath("//div[@class=\"ns-box-inner\"]"));
            
        public void ClickLanguageTab()
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 10);
            languageTab.Click();
        }

        public void CLickAddNewLanguageBtn()
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 10);
            addNewLanguageBtn.Click();           
        }

        public void SetLanguageName(string langName)
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 10);
            languageName.Clear();
            languageName.SendKeys(langName);
        }

        public void SetLevel(string level) 
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//select[@name='level']", 10);
            SelectElement selectedLevel = new SelectElement(levelDropdownBtn);
            selectedLevel.SelectByValue(level);
        }

        public void AddNewLang()
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 3);
            addLanguageBtn.Click();
        }

        public string CheckNewLanguageAdded(string newLanguage)
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//div[@class=\"ns-box-inner\"]", 20);
            string successMessage = successNotification.Text;
            return successMessage;         

        }

        private IWebElement EditLanguage(string language) => Driver.driver.FindElement(By.XPath("//td[text()='" + language + "']/following::td[2]/descendant::i[@class=\"outline write icon\"]"));
        private IWebElement EditLanguageName(string language) => Driver.driver.FindElement(By.XPath("//input[@value='"+language+"']"));
        private IWebElement EditLevelDropdownBtn(string language) => Driver.driver.FindElement(By.XPath("//input[@value='"+language+"']/following::select[@name='level']"));
        private IWebElement UpdateLanguageBtn(string language) => Driver.driver.FindElement(By.XPath("//input[@value='"+ language +"']/following::span[@class=\"buttons-wrapper\"]/descendant::INPUT[@value=\"Update\"]"));
        
        public void EditExistingLanguage(string currentLanguage, string newLanguage)
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var editLanguage = EditLanguage(currentLanguage);
            editLanguage.Click();
            var editLanguageName = EditLanguageName(currentLanguage);
            editLanguageName.Clear();
            editLanguageName.SendKeys(newLanguage);            
        }       
        

        public void SetNewLevel(string currentLanguage, string newLevel)
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var editLevelDropdownBtn = EditLevelDropdownBtn(currentLanguage);
            SelectElement selectedLevel = new SelectElement(editLevelDropdownBtn);
            selectedLevel.SelectByValue(newLevel);
        }

        public void CLickUpdateLanguageBtn(string currentLanguage)
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var updateLanguageBtn = UpdateLanguageBtn(currentLanguage);
            updateLanguageBtn.Click();
        }

        public string CheckUpdatedLanguage(string newLanguage)
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//div[@class=\"ns-box-inner\"]", 20);
            string successMessage = successNotification.Text;
            return successMessage;
            
        }

        private IWebElement RemoveLanguage(string language) => Driver.driver.FindElement(By.XPath("//td[text()='" + language + "']/following::td[2]/descendant::i[@class=\"remove icon\"]"));

        public void DeleteLanguage(string language)
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var removeLanguage = RemoveLanguage(language);
            removeLanguage.Click();
        }

        public string CheckDeletedLanguage(string language)
        {
            Wait.WaitToBeVisible(Driver.driver, "XPath", "//div[@class=\"ns-box-inner\"]", 20);
            string successMessage = successNotification.Text;
            return successMessage;
           
        }


        
    }
}
