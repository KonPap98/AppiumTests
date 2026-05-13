using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTests.Pages
{
    public class LoginPage
    {
        private readonly AndroidDriver _driver;

        public LoginPage(AndroidDriver driver)
        {
            _driver = driver;
        }


        private By EmailInput => By.XPath("//android.widget.EditText[@hint='Email']");
        private By PasswordInput => By.XPath("//android.widget.EditText[@hint='Password']");
        private By LoginButton => MobileBy.AccessibilityId("LOGIN");

        public void Login(string email, string password)
        { 
            var emailField = _driver.FindElement(EmailInput);
            emailField.Click();
            emailField.SendKeys(email);

            var passwordField = _driver.FindElement(PasswordInput);
            passwordField.Click();
            passwordField.SendKeys(password);

            _driver.FindElement(LoginButton).Click();
        }
    }
}
