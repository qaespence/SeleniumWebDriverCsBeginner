
using AutoTestFramework.UIElements;
using OpenQA.Selenium.Chrome;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver(@"e:\CodeArea\");
            Driver.driver.Navigate().GoToUrl(Config.baseUrl);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

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
