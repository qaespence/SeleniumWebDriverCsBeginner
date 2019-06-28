using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumCodingExercises.Lessons
{
    class HandlingSpecialElements
    {

        static IWebDriver driver = new ChromeDriver(@"E:\CodeArea\");
        static IWebElement textBox;
        static IWebElement checkBox;
        static IWebElement radioButton;
        static IWebElement dropDownMenu;
        static IWebElement elementFromTheDropDownMenu;
        static IAlert alert;
        static IWebElement image;

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 3: Handling Special Elements: Text Input Field
        // </summary>
        public static void TextInputTextBox()
        {
            string url = "http://testing.todorvachev.com/special-elements/text-input-field/";

            driver.Navigate().GoToUrl(url);

            textBox = driver.FindElement(By.Name("username"));

            textBox.SendKeys("Test text");

            Thread.Sleep(3000);

            Console.WriteLine(textBox.GetAttribute("maxlength"));

            Thread.Sleep(3000);

            driver.Quit();
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 3: Handling Special Elements: Check Box
        // </summary>
        public static void CheckBox()
        {
            string url = "http://testing.todorvachev.com/special-elements/check-button-test-3/";
            string option = "3";

            driver.Navigate().GoToUrl(url);

            checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));

            if (checkBox.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The checkbox is checked!");
            }
            else
            {
                Console.WriteLine("The checkbox is not checked!");
            }

            driver.Quit();
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 3: Handling Special Elements: Radio Button
        // </summary>
        public static void RadioButton()
        {
            string url = "http://testing.todorvachev.com/special-elements/radio-button-test/";
            string[] option = { "1", "3", "5" };

            driver.Navigate().GoToUrl(url);

            for (int i = 0; i < option.Length; i++)
            {
                radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type =\"radio\"]:nth-child(" + option[i] + ")"));

                if (radioButton.GetAttribute("checked") == "true")
                    Console.WriteLine("The " + (i + 1) + " radio button is checked!");
                else
                    Console.WriteLine("This is one of the unchecked radio buttons.");
            }

            driver.Quit();
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 3: Handling Special Elements: Drop Down Menu
        // </summary>
        public static void DropDownMenu()
        {
            string url = "http://testing.todorvachev.com/special-elements/drop-down-menu-test/";
            string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

            driver.Navigate().GoToUrl(url);

            dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

            Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine("The third option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));

            elementFromTheDropDownMenu.Click();

            Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));
            Thread.Sleep(3000);

            for (int i = 1; i <= 4; i++)
            {
                dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
                elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

                Console.WriteLine("The " + i + " option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
            }

            Thread.Sleep(15000);

            driver.Quit();
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 3: Handling Special Elements: Alert Box
        // </summary>
        public static void AlertBox()
        {
            string url = "http://testing.todorvachev.com/special-elements/alert-box/";

            driver.Navigate().GoToUrl(url);

            alert = driver.SwitchTo().Alert();

            Console.WriteLine(alert.Text);

            alert.Accept();

            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

            try
            {
                if (image.Displayed)
                {
                    Console.WriteLine("The alert was successfuly accepted and I can see the image!");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Something went wrong!!");
            }

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}
