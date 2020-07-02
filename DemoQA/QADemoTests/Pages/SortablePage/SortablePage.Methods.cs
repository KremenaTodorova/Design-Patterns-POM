using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class SortablePage : BaseDemoQAPage
    {
        public SortablePage(WebDriver driver)
           : base(driver)
        {

        }
        public override string Url => "http://demoqa.com/sortable";
        public void SortableTest_When_MovedUp()
        {
            Builder
                .DragAndDrop(FourNumberButton.WrappedElement, FirstNumberButton.WrappedElement)
                .Release()
                .Perform();
        }
        public void SortableTest_When_MovedDown()
        {
            Builder
               .DragAndDrop(ThirdNumberButton.WrappedElement, SixthNumberButton.WrappedElement)
               .Release()
               .Perform();
        }

    }
}
