
using DemoQA.QADemoTests.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class ResizablePage
    {

        public void Assert_ResizePositonTest_When_Vertical_Move(WebElement element)
        {

            Assert.AreEqual(237, element.Location.Y);
        }
        public void Assert_ResizePositonTest_When_Horizon_Move(WebElement element)
        {
            Assert.AreEqual(360, element.Location.X);

        }
    }
}
