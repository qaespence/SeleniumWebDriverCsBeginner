using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTestFramework.UIElements
{
    public class RightSideBar
    {
        public RightSideBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
    }
}
