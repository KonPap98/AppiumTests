using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

var options = new AppiumOptions();

options.PlatformName = "Android";
options.AutomationName = "UiAutomator2";

// Your emulator from adb devices
options.AddAdditionalAppiumOption("udid", "emulator-5554");

// Optional
options.DeviceName = "Android Emulator";

options.AddAdditionalAppiumOption("appPackage", "com.EspanolDictionary");
options.AddAdditionalAppiumOption("appActivity", "com.EspanolDictionary.MainActivity");

var driver = new AndroidDriver(
    new Uri("http://127.0.0.1:4723"),
    options
);

Console.WriteLine("Connected to Appium successfully!");

driver.Quit();