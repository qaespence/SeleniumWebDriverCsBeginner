using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoTestFramework.TestScenarios
{
    [Parallelizable]
    class LoginInvalidPassword
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginFormThroughThePost(Driver);
        }

        [Test]
        public void LessThan5Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
