using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class BaseDemoQAPage
    {
        //Navigation Elements                                           
        protected WebElement LeftPanel => Driver.FindElement(By.XPath("//div[contains(@class,'left-pannel')]"));

        public WebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));
       
        public WebElement SubMenu (string subName) => Driver.FindElement(By.XPath($"//span[contains(text(),'{subName}')]"));
        
        public WebElement PageHeader => Driver.FindElement(By.ClassName("main-header"));
    }
}



