using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class SellerDescriptionStepDefinitions
    {
        [Given(@"I navigate to the seller section")]
        public void GivenINavigateToTheSellerSection()
        {
            throw new PendingStepException();
        }

        [When(@"I add or update the seller description with a maximum of (.*) characters")]
        public void WhenIAddOrUpdateTheSellerDescriptionWithAMaximumOfCharacters(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The description should be displayed in my Profile page")]
        public void ThenTheDescriptionShouldBeDisplayedInMyProfilePage()
        {
            throw new PendingStepException();
        }
    }
}
