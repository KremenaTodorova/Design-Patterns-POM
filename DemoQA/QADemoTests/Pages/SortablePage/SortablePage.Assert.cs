using DemoQA.QADemoTests.Core;
using NUnit.Framework;
using OpenQA.Selenium;


namespace DemoQA.QADemoTests.Pages
{
    public partial class SortablePage
    {
        public void Assert_When_Sortable_MovedDown(WebElement element, WebElement element1)
        {

            Assert.AreNotEqual(SixthNumberButtonAfter, SixthNumberButton);
        }

        public void Assert_When_Sortable_MovedUp(WebElement element, WebElement element1)
        {

            Assert.AreNotEqual(FourNumberButtonAfter, FourNumberButton);
        }

    }
}


