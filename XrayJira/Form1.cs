using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XrayJiraTool
{
    public class XrayJiraMain
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]

        public void ViewReportedByMeIssues()
        {
            var xray = new XrayJira(_driver);
            xray.NavigateToURL("https://helpd-itr.liebherr.com/secure/RapidBoard.jspa?rapidView=31");
            xray.EnterXrayViaSSObutton();
            xray.ClickOnSearchBarInJiraTypeProjectNameAndEnterProjectPage();
            xray.SwitchFilterToReportedByMeIssues();
            Assert.AreEqual("Reported by me", _driver.FindElement(By.ClassName("subnavigator-title")).Text);
        }


        [TearDown]
        public void TearDown()
        {

        }
    }
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void MyIssuesBtn_MouseClick(object sender, MouseEventArgs e)
        {
            var gui = new XrayJiraMain();
            gui.SetUp();
            gui.ViewReportedByMeIssues();
        }
    }  
}

