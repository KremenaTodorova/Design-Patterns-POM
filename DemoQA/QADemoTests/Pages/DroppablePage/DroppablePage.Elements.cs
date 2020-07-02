
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class DroppablePage
    {
        public WebElement ToBeDraggedBox => Driver.FindElement(By.Id("draggable"));

        public WebElement DroppedBox => Driver.FindElement(By.Id("droppable"));

        public WebElement AcceptTabButton => Driver.FindElement(By.Id("droppableExample-tab-accept"));

        public WebElement AcceptableBox => Driver.FindElement(By.Id("acceptable"));

        public WebElement NonAcceptableBox => Driver.FindElement(By.Id("notAcceptable"));
    }
}
