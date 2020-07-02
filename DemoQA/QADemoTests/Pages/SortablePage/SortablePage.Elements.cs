
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class SortablePage
    {
        //Sortable  Elements Down
        public WebElement ThirdNumberButton => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(3)"));

        public WebElement SixthNumberButton => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(6)"));

        public WebElement SixthNumberButtonAfter => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(3)"));

        //Sortable  Elements  UP
        public WebElement FirstNumberButton => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(1)"));

        public WebElement FourNumberButton => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(4)"));

        public WebElement FourNumberButtonAfter => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(1)"));
    }
}


