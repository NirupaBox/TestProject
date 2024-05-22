using ByBoxDeliverUITests.Contexts;
using ByBoxDeliverUITests.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;

namespace ByBoxDeliverUITests.Hooks
{
    [Binding]
    public class InitializeHook
    {
        public AppiumDriver<IWebElement>? Driver { get; set; }

        [BeforeFeature] 
        public static void BeforeFeature() 
        {            

        }

        [BeforeScenario] 
        public static void BeforeScenario(CommonContext commonContext) 
        {
            commonContext.Driver = new AppTestsDriver();

            commonContext.Driver = new AppTestsDriver();
            commonContext.Driver.InitialseAppiumForBrowserStack();
        }


       
    }
}
