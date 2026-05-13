using AppiumTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.Enums;

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
        private By RegisterButton => MobileBy.AccessibilityId("Register");
        private By ConfirmPasswordInput => By.XPath("//android.widget.EditText[@hint='Confirm Password']");
        private By SingUpButton => MobileBy.AccessibilityId("SIGN UP");

        public void Login(string email, string password)
        {
            WaitHelper.WaitForElementOnScreen(_driver, EmailInput);
            var emailField = _driver.FindElement(EmailInput);
            emailField.Click();
            emailField.SendKeys(email);

            var passwordField = _driver.FindElement(PasswordInput);
            passwordField.Click();
            passwordField.SendKeys(password);

            _driver.FindElement(LoginButton).Click();
        }

        public void Register(string email, string password)
        {
            if (_driver.IsKeyboardShown())
            {
                _driver.PressKeyCode(AndroidKeyCode.Back);
            }

            var registerButton = _driver.FindElement(RegisterButton);
                registerButton.Click();

            var emailField = _driver.FindElement(EmailInput);
            emailField.Click();
            emailField.SendKeys(email);

            var passwordField = _driver.FindElement(PasswordInput);
            passwordField.Click();
            passwordField.SendKeys(password);

            var confirmPasswordField = _driver.FindElement(ConfirmPasswordInput);
            confirmPasswordField.Click();
            confirmPasswordField.SendKeys(password);

            var signUpButton = _driver.FindElement(SingUpButton);
            signUpButton.Click();
        }
    }
}
