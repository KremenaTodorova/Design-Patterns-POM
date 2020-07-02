
using DemoQA.QADemoTests.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class DraggablePage
    {

        public void Assert_DraggMenuTestAxis_When_Moved_X(WebElement element)
        {
            Assert.AreEqual(750, element.Location.X, 3);
        }
        public void Assert_DraggMenuTestAxis_When_Moved_Y(WebElement element)
        {
            Assert.AreEqual(570, element.Location.Y, 3);

        }
        public void Assert_DraggMenuTestContainerRestrictedTab_When_Moved_In_Wrapper(WebElement element, WebElement element1)
        {
            Assert.LessOrEqual(element.Location.X, element1.Location.X);
            Assert.LessOrEqual(element.Location.Y, element1.Location.Y);

        }
    }
}

