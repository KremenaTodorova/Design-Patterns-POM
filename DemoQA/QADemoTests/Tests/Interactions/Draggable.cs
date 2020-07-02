using NUnit.Framework;
using SeleniumAdvancedHomeworkTest.QADemoTests.Tests;
using DemoQA.QADemoTests.Pages;
using System.IO;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;

namespace DemoQATestsv2.Tests.Interactions
{
        public class Draggable : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _draggablePage = new DraggablePage(Driver);
            _draggablePage.NavigateTo();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.ScreenShots();
            Driver.Quit();
        }


        [Test]
        public void DraggMenuTestAxis_When_Moved_X()
        {
            _draggablePage.DraggMenuTestAxis_When_Moved_X();

            _draggablePage.Assert_DraggMenuTestAxis_When_Moved_X(_draggablePage.RestrictedXButton);
        }

        [Test]
        public void DraggMenuTestAxis_When_Moved_Y()
        {
            _draggablePage.DraggMenuTestAxis_When_Moved_Y();

            _draggablePage.Assert_DraggMenuTestAxis_When_Moved_Y(_draggablePage.RestrictedYButton);

        }
        [Test]
        public void DraggMenuTestContainerRestrictedTab_When_Moved_In_Wrapper()
        {
            _draggablePage.DraggMenuTestContainerRestrictedTab_When_Moved_In_Wrapper();

            _draggablePage.Assert_DraggMenuTestContainerRestrictedTab_When_Moved_In_Wrapper(_draggablePage.ContainerWrapper, _draggablePage.ContainerWithinBox);

        }

    }
}
