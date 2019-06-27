
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
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
}

