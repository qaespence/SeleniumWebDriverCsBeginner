using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCodingExercises.Lessons
{
    public class ElementSelectors
    {

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 2: Element Selectors in Selenium Webdriver: Name
        // </summary>
        public static void Name()
        {
            IWebDriver driver = new ChromeDriver(@"e:\CodeArea\");

            driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

            IWebElement element = driver.FindElement(By.Name("myName"));

            if (element.Displayed)
            {
                GreenMessage("Yes! I can see the element!");
            }
            else
            {
                RedMessage("Something went wrong, I couldn't see the element!");
            }

            driver.Quit();
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 2: Element Selectors in Selenium Webdriver: ID
        // </summary>
        public static void ID()
        {
            string url = "http://testing.todorvachev.com/selectors/id/";
            string ID = "testImage";

            IWebDriver driver = new ChromeDriver(@"e:\CodeArea\");

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.Id(ID));

            if (element.Displayed)
            {
                GreenMessage("Yes! I can see the element!");
            }
            else
            {
                RedMessage("Something went wrong, I couldn't see the element!");
            }

            driver.Quit();
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 2: Element Selectors in Selenium Webdriver: Class Name
        // </summary>
        public static void ClassName()
        {
            string url = "http://testing.todorvachev.com/selectors/class-name/";
            string className = "testClass";

            IWebDriver driver = new ChromeDriver(@"e:\CodeArea\");

            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.ClassName(className));

            Console.WriteLine(element.Text);

            if (element.Displayed)
            {
                GreenMessage("Yes! I can see the element!");
            }
            else
            {
                RedMessage("Something went wrong, I couldn't see the element!");
            }

            driver.Quit();
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 2: Element Selectors in Selenium Webdriver: CSS and X Path
        // </summary>
        public static void CSSandXPath()
        {
            string url = "http://testing.todorvachev.com/selectors/css-path/";
            string cssPath = "#post-108 > div > figure > img";
            string xPath = "//*[@id=\"post-108\"]/div/figure/img";

            IWebDriver driver = new ChromeDriver(@"e:\CodeArea\");

            driver.Navigate().GoToUrl(url);

            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            if (cssPathElement.Displayed)
            {
                GreenMessage("Yes! I can see the CSS Path element!");
            }
            else
            {
                RedMessage("Something went wrong, I couldn't see the CSS Path element!");
            }

            if (xPathElement.Displayed)
            {
                GreenMessage("Yes! I can see the X Path element!");
            }
            else
            {
                RedMessage("Something went wrong, I couldn't see the X Path element!");
            }

            driver.Quit();
        }

        // <summary>
        // Udemy Course - Selenium WebDriver with C# for Beginners + Live Testing Site
        // Section 2: Element Selectors in Selenium Webdriver: Handling NoSuchElementException
        // </summary>
        public static void HandlingNoSuchElementException()
        {
            string url = "http://testing.todorvachev.com/selectors/css-path/";
            string cssPath = "#post-108 > div > fig img";
            string xPath = "//*[@id=\"post-108\"]/div/figure/img";

            IWebDriver driver = new ChromeDriver(@"e:\CodeArea\");

            driver.Navigate().GoToUrl(url);

            IWebElement cssPathElement;
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            try
            {
                cssPathElement = driver.FindElement(By.CssSelector(cssPath));

                if (cssPathElement.Displayed)
                {
                    GreenMessage("Yes! I can see the CSS Path element!");
                }
            }
            catch (NoSuchElementException)
            {

                RedMessage("Something went wrong, I couldn't see the CSS Path element!");

                if (xPathElement.Displayed)
                {
                    GreenMessage("Yes! I can see the X Path element!");
                }
                else
                {
                    RedMessage("Something went wrong, I couldn't see the X Path element!");
                }
            }

            driver.Quit();
        }

    }
}
