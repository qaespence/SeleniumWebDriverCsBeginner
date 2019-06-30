using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace AutoTestFramework.TestScenarios
{
    [Parallelizable]
    class TestNav
    {
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginFormThroughThePost(Driver);
        }

        [Test]
        public void NavigationBar()
        {
            Driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughMenu(Driver);

            Thread.Sleep(500);

            Driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughThePost(Driver);

            Thread.Sleep(5000);

            Driver.Quit();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
