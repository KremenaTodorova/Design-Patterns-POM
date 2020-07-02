
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;
using SeleniumAdvancedHomeworkTest.QADemoTests.Pages;

namespace DemoQA.QADemoTests.Pages
{
    public partial class ResizablePage : BaseDemoQAPage
    {
        public ResizablePage(WebDriver driver) : base(driver)
        {
        }
        public override string Url => "http://demoqa.com/resizable";

        public void ResizePositonTest_When_Vertical_Move()
        {

            Builder
                .ClickAndHold(ButtonForResize.WrappedElement)
                .MoveByOffset(0, 100)
                .Click()
                .Perform();
        }
        public void ResizePositonTest_When_Horizon_Move()
        {

            Builder
                .ClickAndHold(ButtonForResize.WrappedElement)
                .MoveByOffset(299, 0)
                .Click()
                .Perform();
        }
    }
}
