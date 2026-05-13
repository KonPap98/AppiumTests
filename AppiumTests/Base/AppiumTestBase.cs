using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTests.Base
{
    public class AppiumTestBase
    {
        protected AndroidDriver Driver;

        [SetUp]
        public void SetUp()
        {
            var options = new AppiumOptions();

            options.PlatformName = "Android";
            options.AutomationName = "UiAutomator2";
            options.DeviceName = "Android Emulator";

            options.AddAdditionalAppiumOption("udid", "emulator-5554");
            options.AddAdditionalAppiumOption("appPackage", "com.EspanolDictionary");
            options.AddAdditionalAppiumOption("noReset", true);

            Driver = new AndroidDriver(
                new Uri("http://127.0.0.1:4723"),
                options
            );
        }

        [TearDown]
        public void TearDown()
        {
            Driver?.Quit();
        }
    }
}

