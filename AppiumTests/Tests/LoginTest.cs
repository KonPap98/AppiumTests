using NUnit.Framework;
using AppiumTests.Base;
using AppiumTests.Pages;

namespace AppiumTests.Tests
{
    public class LoginTest : AppiumTestBase
    {
        [Test]
        public void DummyLoginTest()
        {
            var loginPage = new LoginPage(Driver);

            loginPage.Login("test@gmail.com", "12345");

            Assert.Pass("Login flow completed");
        }
        [Test]
        public void RegisterUser()
        {
            var loginPage = new LoginPage(Driver);

            loginPage.Register("KonstantinosPapadopoulos98@gmail.com", "Zxc123as@");

            Assert.Pass("Register flow completed");
        }
    }
}
