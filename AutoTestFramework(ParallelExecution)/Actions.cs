
using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver(@"e:\CodeArea\");
            driver.Navigate().GoToUrl(Config.baseUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Config.ElementsWaitingTimeout);

            return driver;
        }

        public static void FillLoginForm(string username, string password, string repeatPassword, IWebDriver driver)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost(driver);

            lsPost.UsernameField.Clear();
            lsPost.PasswordField.Clear();
            lsPost.RepeatPasswordField.Clear();
            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
    }
}
