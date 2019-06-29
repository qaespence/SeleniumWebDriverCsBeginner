using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace AutoTestFramework.TestScenarios
{
    class TestNav
    {
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormThroughThePost();
        }

        [Test]
        public void NavigationBar()
        {
            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughThePost();

            Thread.Sleep(5000);

            Driver.driver.Quit();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
