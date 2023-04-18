using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class SellerLanguagesStepDefinitions
    {
        private readonly SellerLanguages _sellerLanguages;

        public SellerLanguagesStepDefinitions()
        {
            _sellerLanguages = new SellerLanguages();
        }

        
        [Given(@"I navigate to the Languages Section")]
        public void GivenINavigateToTheLanguagesSection()
        {
            _sellerLanguages.ClickLanguageTab();
        }

        [When(@"I add a new '([^']*)'")]
        public void WhenIAddANew(string language)
        {           
            _sellerLanguages.CLickAddNewLanguageBtn();
            _sellerLanguages.SetLanguageName(language);
        }

        [When(@"I select the '([^']*)'")]
        public void WhenISelectThe(string level)
        {

            _sellerLanguages.SetLevel(level);
        }

        [When(@"I save the new language")]
        public void WhenISaveTheNewLanguage()
        {
            _sellerLanguages.AddNewLang();
        }

        [Then(@"The new '([^']*)' should be displayed in the Seller Language List")]
        public void ThenTheNewShouldBeDisplayedInTheSellerLanguageList(string newLanguage)
        {
            ValidateNewlyAddedNewLanguage(newLanguage);
        }

        [When(@"I add an existing language as a new '([^']*)'")]
        public void WhenIAddAnExistingLanguageAsANew(string language)
        {
            
            _sellerLanguages.CLickAddNewLanguageBtn();
            _sellerLanguages.SetLanguageName(language);
        }

        [Then(@"An error message should be displayed of the duplicate '([^']*)'")]
        public void ThenAnErrorMessageShouldBeDisplayedOfTheDuplicate(string newLanguage)
        {
            ValidateNewlyAddedNewLanguage(newLanguage);
        }

        public void ValidateNewlyAddedNewLanguage(string newLanguage)
        {
            string notification = _sellerLanguages.CheckNewLanguageAdded(newLanguage);

            if (notification == (newLanguage + " has been added to your languages"))                
                Assert.That(notification == (newLanguage + " has been added to your languages"), notification);
            else if (notification == "This language is already exist in your language list.")                
                Assert.That(notification == "This language is already exist in your language list.", notification);
            else if (notification == "Duplicated data")                
                Assert.That(notification == "Duplicated data", notification);
            else if (notification == "This language is already added to your language list.")                
                Assert.That(notification == "This language is already added to your language list.", notification);
            else if (notification == "Please enter language and level")                
                Assert.That(notification == "Please enter language and level", notification);
           
        }




        [When(@"I update an existing '([^']*)' to a '([^']*)'")]
        public void WhenIUpdateAnExistingToA(string currentLanguage, string newLanguage)
        {
            _sellerLanguages.EditExistingLanguage(currentLanguage, newLanguage);
        }

        [When(@"I update the Level to a '([^']*)' given the current '([^']*)'")]
        
        public void WhenIUpdateTheLevelToAGivenTheCurrent(string newLevel, string currentLanguage)
        {
            _sellerLanguages.SetNewLevel(currentLanguage,newLevel);
        }

        [When(@"I save the updated '([^']*)'")]
        public void WhenISaveTheUpdated(string currentLanguage)
        {
           _sellerLanguages.CLickUpdateLanguageBtn(currentLanguage);
        }
        
        [Then(@"The updated '([^']*)' should be updated successfully")]
        public void ThenTheUpdatedShouldBeUpdatedSuccessfully(string newLanguage)
        {
            string notification = _sellerLanguages.CheckUpdatedLanguage(newLanguage);

            if (notification == (newLanguage + " has been updated to your languages"))
                Assert.That(notification == (newLanguage + " has been updated to your languages"), notification);
            else if (notification == "This language is already exist in your language list.")
                Assert.That(notification == "This language is already exist in your language list.", notification);
            else if (notification == "Duplicated data")
                Assert.That(notification == "Duplicated data", notification);
            else if (notification == "This language is already added to your language list.")
                Assert.That(notification == "This language is already added to your language list.", notification);
            else if (notification == "Please enter language and level")
                Assert.That(notification == "Please enter language and level", notification);          

        }


        [When(@"I delete an existing '([^']*)'")]
        public void WhenIDeleteAnExisting(string language)
        {
            _sellerLanguages.DeleteLanguage(language);
        }


        [Then(@"The existing '([^']*)' selected should be deleted successfully")]
        public void ThenTheExistingSelectedShouldBeDeletedSuccessfully(string language)
        {
            string notification = _sellerLanguages.CheckDeletedLanguage(language);
            Assert.That(notification == (language + " has been deleted from your languages"), notification);
            
        }


    }
}
