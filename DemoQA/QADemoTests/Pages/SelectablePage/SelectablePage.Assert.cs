using DemoQA.QADemoTests.Core;
using NUnit.Framework;

namespace DemoQA.QADemoTests.Pages
{
    public partial class SelectablePage
    {

        public void Assert_When_SelectableIsSelected(WebElement element, WebElement element1)
        {
            Assert.AreEqual(element1.GetCssValue("color"), element.GetCssValue("color"));
        }

        public void Assert_When_SelectableIsSelected_Unselected(WebElement element)
        {

            Assert.AreEqual("rgba(73, 80, 87, 1)", element.GetCssValue("color"));

        }
    }
}
