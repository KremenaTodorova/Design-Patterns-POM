using NUnit.Framework;
using SeleniumAdvancedHomeworkTest.QADemoTests.Tests;
using DemoQA.QADemoTests.Pages;
using System.IO;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;

namespace DemoQATestsv2.Tests.Interactions
{
    public class Resizable : BaseTest
    {
        private ResizablePage _resizablePage;
       
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigateTo();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.ScreenShots();
            Driver.Quit();
        }
        [Test]
        public void ResizePositonTest_When_Vertical_Move()
        {
            _resizablePage.ResizePositonTest_When_Vertical_Move();

            _resizablePage.Assert_ResizePositonTest_When_Vertical_Move(_resizablePage.BoxToBeResized);

        }
        [Test]
        public void ResizePositonTest_When_Horizon_Move()
        {
            _resizablePage.ResizePositonTest_When_Horizon_Move();

            _resizablePage.Assert_ResizePositonTest_When_Horizon_Move(_resizablePage.BoxToBeResized);


        }
    }
}
