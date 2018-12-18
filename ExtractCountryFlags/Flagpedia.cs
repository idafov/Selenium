namespace ExamPreparation
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using ExamPreparation.Pages.IndexPage;
    using ExamPreparation.Pages.CountryPage;
    using OpenQA.Selenium.Interactions;
    using System.Security.Policy;
    using ExamPreparation.Pages;
    using NUnit.Framework.Interfaces;
    using System.Drawing.Imaging;

    [TestFixture]
    public class Flagpedia
    {
        private IWebDriver _driver;

       

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void ExtractAllCountriesFlags()
        {
            var indexPage = new IndexPage(_driver);
            var countryPage = new CountryPage(_driver);
            indexPage.NavigateTo("http://flagpedia.net/index");

            var countryNames = indexPage.CountryNames;

            List<string> namesOfCountries = new List<string>();
            foreach (var country in countryNames)
            {
                country.Text.Trim(' ').ToLower();
                
                namesOfCountries.Add(country.Text.Replace(" ", "-"));                                
            }

            foreach (var country in namesOfCountries)
            {
                indexPage.NavigateTo("http://flagpedia.net/" + country);

               // var saveImage = countryPage.FlagsImage;
               //saveImage.SaveAsFile(Path.GetFullPath(@"C:\Users\lhmdai1\Documents\New folder\") + BuildName(countryPage) + ".png", ScreenshotImageFormat.Png);
                var image = ((ITakesScreenshot)_driver).GetScreenshot();
                image.SaveAsFile(Path.GetFullPath(@"C:\Users\lhmdai1\Documents\New folder\") + BuildName(countryPage)+".png" , ScreenshotImageFormat.Png);
            }
        }
        private string BuildName(CountryPage page)
        {
            return $"{page.Name.Text}-{page.Capital.Text}-{page.Code.Text}";
        }
    }
}
