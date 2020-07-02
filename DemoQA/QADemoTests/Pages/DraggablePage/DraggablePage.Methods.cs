using DemoQA.QADemoTests.Core;

namespace DemoQA.QADemoTests.Pages
{
    public partial class DraggablePage : BaseDemoQAPage
    {
        public DraggablePage(WebDriver driver) : base(driver)
        {
        }
        public override string Url => "http://demoqa.com/dragabble";


        public void DraggMenuTestAxis_When_Moved_X()
        {
            DraggableAxisButton.Click();
            Builder
               .DragAndDropToOffset(RestrictedXButton.WrappedElement, 250, 100)
               .Click()
               .Perform();
        }
        public void DraggMenuTestAxis_When_Moved_Y()
        {
            DraggableAxisButton.Click();

            Builder
              .DragAndDropToOffset(RestrictedYButton.WrappedElement, 150, 250)
              .Click()
              .Perform();
        }
        public void DraggMenuTestContainerRestrictedTab_When_Moved_In_Wrapper()
        {
            ContainerRestrictedButton.Click();

            Builder
                .DragAndDropToOffset(ContainerWithinBox.WrappedElement, 150, 100)
                .Click()
                .Perform();
        }
    }
}
