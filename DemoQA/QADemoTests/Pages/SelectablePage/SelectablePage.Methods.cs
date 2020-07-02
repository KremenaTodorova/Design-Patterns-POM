using DemoQA.QADemoTests.Core;

namespace DemoQA.QADemoTests.Pages
{
    public partial class SelectablePage : BaseDemoQAPage
    {
        public SelectablePage(WebDriver driver) : base(driver)
        {
        }
        public override string Url => "http://demoqa.com/selectable";
        public void SelectableTests_When_Selected()
        {
            Builder
                  .Click(FirstTextButton.WrappedElement)
                  .Click(LastTextButton.WrappedElement)
                  .Release()
                  .Perform();
        }
        public void SelectableTests_When_UnSelected()
        {
            Builder
               .Click(LastTextButton.WrappedElement)
               .Release()
               .Click(LastTextButton.WrappedElement)
               .Release()
               .Perform();
        }

    }
}
