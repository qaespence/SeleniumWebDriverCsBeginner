using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace AutoTestFramework.TestScenarios
{
    [Parallelizable]
    class TestValidLogin
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();

        }

        [Test]
        public void ValidLogin()
        {
            Driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughMenu(Driver);
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
