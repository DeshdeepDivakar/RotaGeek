using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace LookupRotaGeek
{
    public static class Initialiser
    {
        public static IWebDriver _driver;
        public static IWebDriver GetDriver(string browserName, int timeout = 3)
        {
            string path = ConfigurationManager.AppSettings["SeleniumDriverPath"];
            _driver = new ChromeDriver(path);
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeout));
            return _driver;
        }
        public static void Open(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            _driver.Quit();
        }

    }
}
