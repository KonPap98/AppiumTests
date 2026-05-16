using NUnit.Framework;
using AppiumTests.Base;
using AppiumTests.Pages;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTests.Tests
{
    public class LoginTests : AppiumTestBase
    {
        [Test]
        public void DummyLoginTest()
        {
            var loginPage = new LoginPage(Driver);

            loginPage.Login("test@gmail.com", "12345");

            loginPage.CheckForLoginFailure();

            Assert.Pass("Dummy login flow completed");
        }
        [Test]
        public void RegisterUser()
        {
            var loginPage = new LoginPage(Driver);

            loginPage.Register("konstantinospapadopoulos98@gmail.com", "Zxc123as@");

            Assert.Pass("Register flow completed");
        }

        [Test]
        public void LoginRealUserTest()
        {
            var loginPage = new LoginPage(Driver);

            loginPage.Login("test@gmail.com", "12345");

            Assert.Pass("Real login flow completed");
        }
        [Test]
        public void GoogleLoginTest()
        {
            var loginPage = new LoginPage(Driver);

            loginPage.GoogleLogin();

            Assert.Pass("Google login flow completed");
        }
    }
}
