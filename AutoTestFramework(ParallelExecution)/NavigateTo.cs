
using AutoTestFramework.UIElements;
using OpenQA.Selenium;
using System.Threading;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);
        }

        public static void LoginFormThroughThePost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameFieldPost ufPost = new UsernameFieldPost(driver);

            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.UsernameCase.Click();
            Thread.Sleep(500);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(500);

        }

    }
}
