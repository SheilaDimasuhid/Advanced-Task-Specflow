using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class SellerFullNameStepDefinitions
    {
        private readonly SellerFullName _sellerFullName;

        public SellerFullNameStepDefinitions()
        {
            _sellerFullName = new SellerFullName();
        }

        [Given(@"I navigate to the Full Name Drop Down button")]
        public void GivenINavigateToTheFullNameDropDownButton()
        {
            _sellerFullName.navigateDropDown();
        }

        [When(@"I update my '([^']*)' and '([^']*)'")]
        public void WhenIUpdateMyAnd(string fName, string lName)
        {
            _sellerFullName.SetFirstname(fName);
            _sellerFullName.SetLastname(lName);
        }

        [When(@"I save the Full Name")]
        public void WhenISaveTheFullName()
        {   
            
         _sellerFullName.SaveFullName();

        }

        [Then(@"I have updated my '([^']*)' successfully")]
        public void ThenIHaveUpdatedMySuccessfully(string fullname)
        {
            _sellerFullName.CheckFullname(fullname);
        }

    }
}
