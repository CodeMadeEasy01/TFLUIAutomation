using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TFLUIAutomation.Drivers;

namespace TFLUIAutomation.Hooks
{
    [Binding]
    public sealed class BaseClass
    {

        [Binding]
        public sealed class Hooks : DriverHelper
        {
            IObjectContainer container;

           

            public Hooks(IObjectContainer _container)
            {
                container = _container;
            }

            [BeforeScenario]
            public void BeforeScenario()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                container.RegisterInstanceAs<IWebDriver>(driver);
                //Assert.True(driver.Url.Contains("tfl"));
                Thread.Sleep(1000);
            }



            [AfterScenario]
            public void AfterScenario()
            {
                driver?.Quit();
            }


            public void TakeScreenShotAtPointOfTesFailure(string directory, string scenarioName)
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string path = directory + scenarioName + DateTime.Now.ToString("YYYY-MM-dd") + ".png";
                string Screenshot = screenshot.AsBase64EncodedString;
                byte[] screenshotAsByteArray = screenshot.AsByteArray;
               // object ScreenshotImageFormat = null;
                //screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
            }
        }

    }
}