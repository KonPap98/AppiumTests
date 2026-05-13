using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace AppiumTests.Helpers
{
    public static class WaitHelper
    {
        public static IWebElement WaitForElement(AndroidDriver driver, By locator, int seconds = 10)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            return wait.Until(d =>
            {
                var elements = driver.FindElements(locator);

                if (elements.Count > 0 && elements[0].Displayed)
                {
                    return elements[0];
                }

                return null;
            });
        }

        public static void WaitForElementOnScreen(AndroidDriver driver, By locator, int seconds = 10)
        {
            WaitForElement(driver, locator, seconds);
        }
    }
}