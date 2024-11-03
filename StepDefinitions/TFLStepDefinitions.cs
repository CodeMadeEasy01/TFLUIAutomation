using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using TFLUIAutomation.Pages;

namespace TFLUIAutomation.StepDefinitions
{
    [Binding]
    public sealed class TFLStepDefinitions
    {

        HomePage homePage;

        public TFLStepDefinitions(IObjectContainer container)
        {

            {
                // driver= container.Resolve<IWebDriver>();
                homePage = container.Resolve<HomePage>();
              

            }
        }

        [Given(@"I naviagate to the TFL journey planner page")]
        public void GivenINaviagateToTheTFLJourneyPlannerPage()
        {
            homePage.NavigateTotflSite("tflUrl");
            homePage.ClickOnAcceptCookiesButton();
            homePage.verifytheHomePageText();
        }

        [When(@"I enter ""([^""]*)"" as the start point")]
        public void WhenIEnterAsTheStartPoint(string startPoint)
        {
            homePage.EnterStartPointText(startPoint);
                
        }

        [When(@"I  select ""([^""]*)"" as the destination")]
        public void WhenISelectAsTheDestination(string destinationPoint)
        {
            homePage.EnterDestinationText(destinationPoint); 
        }

        [When(@"I click on Plan my journey button")]
        public void WhenIClickOnPlanMyJourneyButton()
        {
            homePage.ClickOnPlanJourneyButton();
        }

        [Then(@"I  should see valid walking and cycling times")]
        public void ThenIShouldSeeValidWalkingAndCyclingTimes()
        {
           Assert.IsTrue(homePage.VerifyWalkingAndCyclingTimes());  
        }

        [When(@"I click on Edit Preference button")]
        public void WhenIClickOnEditPreferenceButton()
        {
            homePage.ClickOnPlanJourneyButton();
        }

        [When(@"I select least walking")]
        public void WhenISelectLeastWalking()
        {
            homePage.selectleasingWalking();    
        }

        [When(@"I  click on update journey")]
        public void WhenIClickOnUpdateJourney()
        {
            homePage.ClickOnUpdateJourney();
        }

        [Then(@"I should see updated journey time")]
        public void ThenIShouldSeeUpdatedJourneyTime()
        {
            Assert.IsTrue(homePage.VerifyUpdatedTimes());   
        }

        [When(@"I select a routes with least walking")]
        public void WhenISelectARoutesWithLeastWalking()
        {
            homePage.selectleasingWalking();
        }

        [When(@"I click on View Details button")]
        public void WhenIClickOnViewDetailsButton()
        {
            homePage.ClickOnViewDetails();
            Assert.IsTrue(homePage.verifyAccessInformation());
        }

        [Then(@"I should see complete access information for Covent Garden Underground Station")]
        public void ThenIShouldSeeCompleteAccessInformationForCoventGardenUndergroundStation()
        {
            Assert.IsTrue(homePage.verifyAccessInformation());
        }

        [Given(@"I naviagate to the TFL Joruney Planner page")]
        public void GivenINaviagateToTheTFLJoruneyPlannerPage()
        {
            homePage.NavigateTotflSite("tflUrl");
            homePage.ClickOnAcceptCookiesButton();  
        }

        [When(@"I enter ""([^""]*)"" as the destination")]
        public void WhenIEnterAsTheDestination(string destinationPoint)
        {
            homePage.EnterDestinationText(destinationPoint);
        }

        [When(@"I click on Plan my Joruney button")]
        public void WhenIClickOnPlanMyJoruneyButton()
        {
            homePage.ClickOnPlanJourneyButton();
        }

        [Then(@"I should see no results available")]
        public void ThenIShouldSeeNoResultsAvailable()
        {
            Assert.IsTrue(homePage.verifyNoResults());
        }

        [When(@"I click on Plan my Joruney without entering any locations")]
        public void WhenIClickOnPlanMyJoruneyWithoutEnteringAnyLocations()
        {
            homePage.NavigateTotflSite("tflUrl");
            homePage.ClickOnAcceptCookiesButton();
            homePage.ClickOnPlanJourneyButton();
        }


        [Then(@"I should see an error message indicating no locations entered")]
        public void ThenIShouldSeeAnErrorMessageIndicatingNoLocationsEntered()
        {
            Assert.IsTrue(homePage.verifyErrorMessage());
        }






    }



}