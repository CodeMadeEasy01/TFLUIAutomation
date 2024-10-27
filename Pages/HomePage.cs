using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLUIAutomation.Pages
{
    public class HomePage
    {

        IWebDriver driver;
        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
        }

        //Method 
        public void NavigateTotflSite(string lgUrl) => driver.Navigate().GoToUrl(Environment.tfl_url);

        public void ClickOnAcceptCookiesButton()
        {
            var CookiePopButton = driver.FindElement(By.XPath("//strong[text()='Accept all cookies']"));
                CookiePopButton.Click();
        }

        public void verifytheHomePageText() => Assert.That(driver.PageSource.Contains("tfl"));


        public void EnterStartPointText(string startPoint)
        {
            var startPointText = driver.FindElement(By.XPath("//input[@id='InputFrom']"));
            startPointText.SendKeys(startPoint);
        }



        public void EnterDestinationText(string destination)
        {
            var destinationText = driver.FindElement(By.XPath("//input[@id='InputTo']"));
               destinationText.SendKeys(destination);
        }

        public void ClickOnPlanJourneyButton()
        {
            var planjourneyButton = driver.FindElement(By.XPath("(//input[contains(@class,'plan-journey-button')])[1]"));
                Thread.Sleep(2000);
                planjourneyButton.Click();
        }

        public void ClickOnEditJoruney()
        {
            var editJoruneyButton = driver.FindElement(By.XPath(""));
                
        }
        
        public bool VerifyWalkingAndCyclingTimes()
        {
            string WalkingTimes = driver.FindElement(By.XPath("(//div[@class='two-col'])[1]")).Text;
            return WalkingTimes.Equals("Journey planner could not find any results to your search. Please try again");
        }

        public void ClickOnEditPreferenceButton()
        {
            var editPrefenceButton = driver.FindElement(By.XPath("//button[text()='Edit preferences']"));
                editPrefenceButton.Click();

        } 

        public void ClickOnLeastWalikingRoutes()
        {
            var leastWalkingRadio = driver.FindElement(By.XPath("//label[text()='Routes with least walking']"));
               leastWalkingRadio.Click();   
        }
       
        public void selectleasingWalking() 
        {
            var leastWalkingOption = driver.FindElement(By.XPath("//label[@for='JourneyPreference_2']"));
            leastWalkingOption.Click();
        }


        public bool VerifyUpdatedTimes()
        {

            string verifyUpdatedTime = driver.FindElement(By.XPath("(//span[text()='Journey results'])[2]")).Text;
            return verifyUpdatedTime.Equals("journey result");
        }

        public bool VerifyUpdated()
        {
            string updatedJourney = driver.FindElement(By.XPath("(//div[@class='clearfix update-buttons']//input[@value='Update journey'])[2]")).Text;
            return updatedJourney.Equals("");

        }

        public bool verifyAccessInformation()
        {
            string accessinformatiionText = driver.FindElement(By.XPath("(//span[text()='Covent Garden Underground Station'])[2]")).Text;
            return accessinformatiionText.Equals("Covent  Garden Underground Station");
        }
        public void ClickOnWalkingMethodLink()
        {
            var WalkingLink = driver.FindElement(By.XPath("//div[@class='method walking notranslate']"));
            WalkingLink.Click();
        }
       

        public void ClickOnViewDetails()
        {
            var viewDetailsButton = driver.FindElement(By.XPath("(//button[text()='View details'])[1]"));
                viewDetailsButton.Click();  
        }

        public void ClickOnLeastWalkingMethod()
        {
            var leastWalking = driver.FindElement(By.XPath("//h4[text()='Least walking']"));
            leastWalking.Click();
        }

        public void ClickOnUpdateJourney()
        {
            var updateJournyButton = driver.FindElement(By.XPath("(//div[@class='clearfix update-buttons']//input[@value='Update journey'])[1]"));
               updateJournyButton.Click();  
        }


        //public void ClickOnViewDetails()
        //{
        //    var ViewDetailsButton = driver.FindElement(By.XPath(""));
        //        ViewDetailsButton.Click();  
        //}


        public bool requiredfieldErrorText()
        {
            var fieldErrorText = driver.FindElement(By.XPath("//span[text()='The From field is required.']")).Text;
            return fieldErrorText.Equals(fieldErrorText);
           
        }








    }

}

