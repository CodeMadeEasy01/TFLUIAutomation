using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.DOM;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public void NavigateTotflSite(string tflUrl) => driver.Navigate().GoToUrl(Environment.tfl_url);

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

            IWebElement planMyJourneyButton = driver.FindElement(By.XPath("//div[@id='plan-a-journey']//input[@id='plan-journey-button']"));
            driver.Manage().Timeouts().ImplicitWait =TimeSpan.FromSeconds(20);
            planMyJourneyButton.Click();


            //IWebElement planMyJourneyButton = driver.FindElement(By.XPath("(//input[@value='Plan my journey'])[1]"));
            //DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(planMyJourneyButton);
            //wait.Timeout = TimeSpan.FromMinutes(2);
            //wait.PollingInterval = TimeSpan.FromMilliseconds(250);

            //Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement planMyJourneyButton) =>
            //{
            //    var planJourneyText = planMyJourneyButton.GetAttribute("Plan my journey");
            //    if (planJourneyText.Contains("Plan my journey"))
            //    {
            //        return true;

            //    }
            //    Console.WriteLine("Plan my journey");
            //    return false;
            //}); wait.Until(waiter);
        }




        public void ClickOnEditJoruney()
        {
            var editJoruneyButton = driver.FindElement(By.XPath(""));
                
        }
        
        public bool VerifyWalkingAndCyclingTimes()
        {
            string WalkingTimes = driver.FindElement(By.XPath("/html/body/div[4]/main/div/div[7]/div/div[1]/a[2]/div[2]/div[2]")).Text;
            return WalkingTimes.Equals("6mins");
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
            return verifyUpdatedTime.Equals("Journey results");
        }

        //public bool VerifyUpdated()
        //{
        //    string updatedJourney = driver.FindElement(By.XPath("(//div[@class='clearfix update-buttons']//input[@value='Update journey'])[2]")).Text;
        //    return updatedJourney.Equals("");

        //}

        public bool verifyAccessInformation()
        {
            string accessinformatiionText = driver.FindElement(By.XPath("(//span[text()='Covent Garden Underground Station'])[2]")).Text;
            return accessinformatiionText.Equals("Covent Garden Underground Station");
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
            var leastWalking = driver.FindElement(By.XPath("//label[text()='Routes with least walking']"));
            leastWalking.Click();
        }

        public void ClickOnUpdateJourney()
        {
            var updateJournyButton = driver.FindElement(By.XPath("(//input[@type='submit'])[2]"));
               updateJournyButton.Click();  
        }

        public bool verifyErrorMessage()
        {
            var fieldErrorText = driver.FindElement(By.XPath("//span[text()='The From field is required.']")).Text;
            return fieldErrorText.Equals(fieldErrorText);

        }

        public bool verifyNoResults()
        {
            String noLocationText = driver.FindElement(By.XPath("(//strong[text()='Invalid Location'])[2]")).Text;
            return noLocationText.Equals(noLocationText);   
        }


        //public void ClickOnViewDetails()
        //{
        //    var ViewDetailsButton = driver.FindElement(By.XPath(""));
        //        ViewDetailsButton.Click();  
        //}











    }

}

