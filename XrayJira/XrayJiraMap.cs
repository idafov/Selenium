using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrayJiraTool
{
    public partial class XrayJira
    {
        public IWebElement SSObutton => Driver.FindElement(By.XPath(@"//*[@id=""login-form""]/fieldset[2]/div[2]/a"));

        public IWebElement SearchBar => Driver.FindElement(By.Id("quickSearchInput"));

        public IWebElement ViewAllMatchingProjectOptionInSearchBar => Driver.FindElement(By.PartialLinkText("View all matching projects"));

        public IWebElement ProjectNameAfterAllMatchingProjectsDisplayed => Driver.FindElement(By.PartialLinkText("Test for ElectronicPlattform Development"));

        public IWebElement SwitchFilterOption => Driver.FindElement(By.XPath(@"//*[@id=""subnav-trigger""]"));

        public IWebElement ReportedByMeIssuesButton => Driver.FindElement(By.PartialLinkText("Reported by me"));

        
    }
}
