using System;
using OpenQA.Selenium;
using LookupRotaGeek;
using System.Collections.Generic;
using System.Linq;

namespace RotaGeek.Tests.Pages
{
    public class GoogleSearchPage
    {
        public void search(string search)
        {
            IWebElement searchBox = Initialiser._driver.FindElement(By.XPath("//div//input[@name='q']"));
            searchBox.SendKeys(search);
        }

        public string retrieveHomeLinkString()
        {
            string Home = Initialiser._driver.FindElement(By.XPath("//div[@class='g']//h3/a")).Text;
            return Home;
        }

        public List<IWebElement> subTitles;
        public List<string> retrieveSubTitles()
        {
            List<string> values = new List<string>();
            subTitles=Initialiser._driver.FindElements(By.XPath("//table[@class='nrgt']//a[@class='l']")).ToList<IWebElement>(); 
            foreach (var item in subTitles)
            {
                values.Add(item.Text);
            }
            return values;
        }

    }
}
