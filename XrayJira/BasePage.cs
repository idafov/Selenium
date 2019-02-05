using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrayJiraTool
{
    public class BasePage
    {

        public IWebDriver Driver { get; set; }
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateToURL(string url)
        {
            this.Driver.Url = url;
        }
    }
}
