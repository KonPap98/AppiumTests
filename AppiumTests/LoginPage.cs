using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTests
{
    public class LoginPage
    {
        private readonly AndroidDriver _driver;

        public LoginPage(AndroidDriver driver)
        {
            _driver = driver;
        }

        private By UsernameInput => By.Id("com.example.app:id/username");
        private By PasswordInput => By.Id("com.example.app:id/password");
        private By LoginButton => By.Id("com.example.app:id/login_button");

        public void Login(string username, string password)
        {
            _driver.FindElement(UsernameInput).SendKeys(username);
            _driver.FindElement(PasswordInput).SendKeys(password);
            _driver.FindElement(LoginButton).Click();
        }
    }
}
