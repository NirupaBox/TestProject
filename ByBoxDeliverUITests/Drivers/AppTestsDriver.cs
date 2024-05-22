using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace ByBoxDeliverUITests.Drivers
{
    public class AppTestsDriver
    {
        public AppTestsDriver() 
        {

        }
        public AppiumDriver<IWebElement>? _driver { get; private set; }

        public AppiumOptions GetAppiumOptions()
        {
            AppiumOptions options = new AppiumOptions();
            Dictionary<string, object> browserstackOptions = new Dictionary<string, object>
            {
                { "projectName", "ByBox Deliver" },
                { "appiumVersion", "2.0.1" },
                { "userName", "nirupa_Oa0hzD" },
                { "accessKey", "QLmpdubLYWWspM9FvJ3r" }

            };
            
            options.AddAdditionalAppiumOption("bstack:options", browserstackOptions);
            options.AddAdditionalAppiumOption("PlatformName", "Android");           
            options.AddAdditionalAppiumOption("os_version", "13.0");
            options.AddAdditionalAppiumOption("DeviceName", "Pixel 6");
            options.AddAdditionalAppiumOption("AutomationName", "UiAutomator2");
            options.AddAdditionalAppiumOption("appium:app", "bs://052671c61587a27130522b5e54ad9371ec03805d");
            options.AddAdditionalAppiumOption("appPackage", "com.bybox.loki");
            options.AddAdditionalAppiumOption("appActivity", "crc6430823b10bda5afd5.MainActivity");
            options.AddAdditionalAppiumOption("appium:app", "");
            options.AddAdditionalAppiumOption("language", "En");
            options.AddAdditionalAppiumOption("interactiveDebugging", "true");

            return options;
        }

        public void InitialseAppiumForBrowserStack()
        {
            var uri = new Uri("http://hub-cloud.browserstack.com/wd/hub");

            _driver = new AndroidDriver<IWebElement>(uri,GetAppiumOptions());
        }











    }
}
