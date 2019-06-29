using AutoTestFramework.UIElements;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutoTestFramework
{
    class Program
    {
        IAlert alert;

        static void Main()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();

        }

        [Test]
        public void TestValidLogin()
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


        public static void TestNav()
        {
            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughThePost();

            Thread.Sleep(5000);

            Driver.driver.Quit();

        }



    }

}