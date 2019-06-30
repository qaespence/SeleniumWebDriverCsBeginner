using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTestFramework.UIElements
{
    public class RightSideBar
    {
        public RightSideBar(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
