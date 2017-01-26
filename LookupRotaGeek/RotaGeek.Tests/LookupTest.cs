using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LookupRotaGeek;
using RotaGeek.Tests.Pages;
using System.Collections.Generic;

namespace RotaGeek.Tests
{
    [TestClass]
    public class LookupTest
    {
        [TestMethod]
        public void LookupRotaGeek()
        {
            Initialiser.GetDriver("Chrome");
            Initialiser.Open("http://www.google.com");

            //Search RotaGeek 
            GoogleSearchPage gsp = new GoogleSearchPage();
            gsp.search("RotaGeek");

            //Retrieve Home Link as string
            string HomeLink = gsp.retrieveHomeLinkString();
            Assert.AreEqual(HomeLink, "RotaGeek: Home");

            //Retrieve SubTitles as string
            List<string> subTitles = gsp.retrieveSubTitles();
            List<string> expectedSubtitles = new List<string>
            {
                "Sign In","Careers","Healthcare","Retailers","Customers","About"

            };

            //Compare SubTitles
            int i = 0;
            foreach (var item in subTitles)
            {                
                Assert.AreEqual(item, expectedSubtitles[i]);
                i++;
            }

            Initialiser.Quit();
        }      
        
    }
}
