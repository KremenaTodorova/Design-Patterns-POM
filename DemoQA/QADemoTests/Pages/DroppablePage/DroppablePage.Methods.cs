

using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class DroppablePage : BaseDemoQAPage
    {
        public DroppablePage(WebDriver driver) : base(driver)
        {
        }
        public override string Url => "http://demoqa.com/droppable";


        public void DroppableMenuTestSimpleTab_When_Dropped()
        {
            Builder
                .DragAndDrop(ToBeDraggedBox.WrappedElement, DroppedBox.WrappedElement)
                .Click()
                .Perform();
        }
        public void DroppableMenuTestSimpleTab_When_Dropped_TextChange()
        {
            Builder
                .DragAndDrop(ToBeDraggedBox.WrappedElement, DroppedBox.WrappedElement)
                .Click()
                .Perform();
        }
        public void DroppableMenuTestAcceptTab_When_Moved_Accept_Box()
        {
            AcceptTabButton.Click();
            Builder
                .DragAndDropToOffset(AcceptableBox.WrappedElement, 250, 60)
                .Click()
                .Perform();
        }

        public void DroppableMenuTestAcceptTabWhen_Moved_NonAcceptableBoxNOColorChange()
        {
            AcceptTabButton.Click();
            Builder
                .DragAndDropToOffset(NonAcceptableBox.WrappedElement, 250, -5)
                .Click()
                .Perform();
        }
    }
}
