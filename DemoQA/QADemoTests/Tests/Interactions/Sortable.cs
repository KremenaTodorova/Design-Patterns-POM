using NUnit.Framework;
using SeleniumAdvancedHomeworkTest.QADemoTests.Tests;
using DemoQA.QADemoTests.Pages;
using System.IO;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;


namespace DemoQATestsv2.Tests.Interactions
{
    public class Sortable : BaseTest
    {
        private SortablePage _sortablePage;
        

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateTo();

        }
        [TearDown]
        public void TearDown()
        {
            Driver.ScreenShots();
            Driver.Quit();
        }

        [Test]
        public void SortableMenuTests_When_Move_Down()
        {
            _sortablePage.SortableTest_When_MovedDown();

            _sortablePage.Assert_When_Sortable_MovedDown(_sortablePage.SixthNumberButtonAfter, _sortablePage.SixthNumberButton);
        }

        [Test]
        public void SortableMenuTests_When_Move_Up()
        {
            _sortablePage.SortableTest_When_MovedUp();

            _sortablePage.Assert_When_Sortable_MovedUp(_sortablePage.FourNumberButtonAfter, _sortablePage.FourNumberButton);

        }
    }
}
