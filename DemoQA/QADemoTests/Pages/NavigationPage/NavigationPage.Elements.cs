using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;
using SeleniumAdvancedHomeworkTest.QADemoTests.Pages;

namespace DemoQA.QADemoTests.Pages
{
    public partial class NavigationPage : BasePage
    {
        public WebElement CategoryButton(string categoryName) =>
           Driver.FindElement(By.XPath($"//*[normalize-space(text())='{categoryName}']/ancestor::div[contains(@class, 'top-card')]"));
    }
}



