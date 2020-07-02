using NUnit.Framework;

namespace DemoQA.QADemoTests.Pages
{
    public partial class BaseDemoQAPage
    {
        public void AssertNavigationIsCorrect(string expectedTitle)
        {

            Assert.AreEqual(expectedTitle, PageHeader.Text);
        }
    }
}
