using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace AutoTestFramework.TestScenarios
{
    class TestValidLogin
    {
        IAlert alert;

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

        }

        [Test]
        public void ValidLogin()
        {
            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
