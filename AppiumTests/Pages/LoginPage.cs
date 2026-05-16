using AppiumTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.Enums;
using System.ComponentModel;

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
        private By InvalidLoginCredPopUp => MobileBy.AccessibilityId("Invalid login credentials");
        private By AnonymusSingInsDisabledPopUp => MobileBy.AccessibilityId("Anonymous sign-ins are disabled");
        private By GoogleSingInButton => MobileBy.AccessibilityId("Sign in with Google");
        private By GoogleAccount => By.XPath("//android.widget.FrameLayout[@resource-id='com.google.android.gms:id/account_particle_disc']");

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

        public void GoogleLogin()
        {
            WaitHelper.WaitForElementOnScreen(_driver, GoogleSingInButton);

            var googleLoginButton = _driver.FindElement(GoogleSingInButton);
            googleLoginButton.Click();

            WaitHelper.WaitForElementOnScreen(_driver, GoogleAccount);
            var googleAccountSelect = _driver.FindElement(GoogleAccount);
            googleAccountSelect.Click();
        }

        public void CheckForLoginFailure()
        {
            WaitHelper.WaitForElementOnScreen(_driver, InvalidLoginCredPopUp);
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
