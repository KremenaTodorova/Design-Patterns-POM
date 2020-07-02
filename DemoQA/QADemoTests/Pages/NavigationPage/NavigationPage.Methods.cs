using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class NavigationPage
    {

        public NavigationPage(WebDriver driver) : base(driver)
        {
        }
        public override string Url => "http://demoqa.com";
    }
}

