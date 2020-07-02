using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class SelectablePage
    {
        public WebElement FirstTextButton => Driver.FindElement(By.CssSelector("li.mt-2:nth-child(1)"));

        public WebElement LastTextButton => Driver.FindElement(By.CssSelector("li.mt-2:nth-child(4)"));
    }
}
