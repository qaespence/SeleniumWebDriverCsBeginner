using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework.UIElements
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}
