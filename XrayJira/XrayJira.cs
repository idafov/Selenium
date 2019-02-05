using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrayJiraTool
{
    public partial class XrayJira : BasePage
    {
        public XrayJira(IWebDriver driver) : base(driver)
        {

        }

        //TODO actions
        public void EnterXrayViaSSObutton()
        {
            SSObutton.Click();
        }

        public void ClickOnSearchBarInJiraTypeProjectNameAndEnterProjectPage()
        {
            SearchBar.Click();
            SearchBar.SendKeys("Test for ElectronicPlattform Development");
            ViewAllMatchingProjectOptionInSearchBar.Click();
            ProjectNameAfterAllMatchingProjectsDisplayed.Click();
        }

        public void SwitchFilterToReportedByMeIssues()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(SwitchFilterOption));
            clickableElement.Click();
            ReportedByMeIssuesButton.Click();            
        }
    }
}
