using NUnit.Framework;
using Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class BGCSteps
    {
        private AutomationTestSite automationTestSite;

        public BGCSteps(AutomationTestSite automationTestSite)
        {
            this.automationTestSite = automationTestSite;
        }
        [Given(@"The link (.*) is provided")]
        public void GivenTheLinkHttpTest_ComIsProvided(string url)
        {
            automationTestSite.GoToGivenURL(url);
        }
        
        [Then(@"The page title should be (.*)")]
        public void ThenThePageTitleShouldBeTest(string expectedTitle)
        {
            string actualTitle = automationTestSite.getPageTitle();
            Assert.AreEqual(expectedTitle, actualTitle, $"(Expected title was {expectedTitle} but was found as {actualTitle})");
        }

        [Given(@"User logs in using userName as (.*) and password as (.*)")]
        public void GivenUserLogsInUsingUserNameAsLocked_Out_UserAndPasswordAsSecret_Sauce(string userName, string password)
        {
            automationTestSite.EnterTextIntoInputField(PageName.swagLab, Element.swagLabUserName, userName);
            automationTestSite.EnterTextIntoInputField(PageName.swagLab, Element.swagLabPassword, password);
            automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabLoginButton);
        }

        [Then(@"An Error message is displayed as (.*)")]
        public void ThenAnErrorMessageIsDisplayedAsEpicSadfaceSorryThisUserHasBeenLockedOut_(string expectedError)
        {
            string actualError = automationTestSite.getTextOfAnElement(PageName.swagLab, Element.swaglabLoginErrorText);
            Assert.AreEqual(expectedError, actualError, $"(Expected error was {expectedError} but was found as {actualError})");
        }

        [Then(@"User is logged in successfully and (.*) heading is displayed")]
        public void ThenUserIsLoggedInSuccessfullyAndPRODUCTSHeadingIsDisplayed(string expectedHeading)
        {
            string actualHeading = automationTestSite.getTextOfAnElement(PageName.swagLab, Element.swagLabLoginHeader);
            Assert.AreEqual(expectedHeading, actualHeading, $"(Expected heading was {expectedHeading} but was found as {actualHeading})");
        }

        [Then(@"Validate the URL of the page is (.*)")]
        public void ThenValidateTheURLOfThePageIsHttpsWww_Saucedemo_ComInventory_Html(string expectedURL)
        {
            string actualURL = automationTestSite.getCurrentURL();
            Assert.AreEqual(expectedURL, actualURL, $"(Expected URL was {expectedURL} but was found as {actualURL})");
        }

        [Then(@"Validate that there are (.*) items displayed")]
        public void ThenValidateThatThereAreItemsDisplayed(int expectedNumberOfItems)
        {
            int actualCount = automationTestSite.getNumberOfItems(PageName.swagLab, Element.swagLabInventoryItemName);
            Assert.AreEqual(expectedNumberOfItems, actualCount, $"(Expected Items count was {expectedNumberOfItems} but was found as {actualCount})");
        }

        [Then(@"All the items are present on the page as '(.*)'")]
        public void ThenAllTheItemsArePresentOnThePageAsBackpackBoltT_ShirtOnesieBikeLightFleeceJacketT_ShirtRed(List<string> allItems)
        {// need to be worked
            foreach(string expectedProductName in allItems)
            {
                string actualProductName = automationTestSite.getTextOfAnElement(PageName.swagLab, Element.swagLabInventoryItemName);
                actualProductName.Contains(expectedProductName);
            }
        }

        [When(@"User click on Add cart for all items as '(.*)'")]
        public void WhenUserClickOnAddCartForAllItemsAs(List<string> allItems)
        {
            foreach (string expectedProductName in allItems)
            {
                string actualProductName = automationTestSite.getTextOfAnElement(PageName.swagLab, Element.swagLabInventoryItemName);
               switch(expectedProductName)
                {
                    case "Backpack":
                        automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabAddToCartBackPack);
                        break;
                    case "Bolt T-Shirt":
                        automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabAddToCartBoltTShirt);
                        break;
                    case "Onesie":
                        automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabAddToCartOnesie);
                        break;
                    case "Bike Light":
                        automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabAddToCartBikeLight);
                        break;
                    case "Fleece Jacket":
                        automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabAddToCartFleeceJacket);
                        break;
                    case "T - Shirt red":
                        automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabAddTShirtRed);
                        break;
                }
            }
        }

       [StepArgumentTransformation]
        public List<String> TransformToListOfString(string commaSeparatedList)
        {
            return commaSeparatedList.Split(",").ToList();
        }

        [When(@"User clicks on Cart to view items in the cart")]
        public void WhenUserClicksOnCartToViewItemsInTheCart()
        {
            automationTestSite.ClickElementOnPage(PageName.swagLab, Element.swagLabShoppingCartContainer);
        }



    }
}
