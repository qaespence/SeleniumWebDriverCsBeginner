using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace SeleniumScreenshot
{
    class Program
    {
        static void Main()
        {
            IWebDriver chrome = new ChromeDriver(@"e:\CodeArea\");

            string screenshotsDir = Directory.GetCurrentDirectory() + @"\screenshots";

            chrome.Navigate().GoToUrl("http://google.com");
            
            Screenshot googleScreenshot = ((ITakesScreenshot)chrome).GetScreenshot();

            if (Directory.Exists(screenshotsDir))
            {
                Directory.CreateDirectory(screenshotsDir);
            }

            googleScreenshot.SaveAsFile(screenshotsDir + @"\googlescreenshot.png", ScreenshotImageFormat.Png);

            chrome.Quit();
        }
    }
}
