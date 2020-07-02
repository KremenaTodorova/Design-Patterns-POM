using NUnit.Framework;
using SeleniumAdvancedHomeworkTest.QADemoTests.Tests;
using DemoQA.QADemoTests.Pages;
using System.IO;
using OpenQA.Selenium;
using System.Linq;
using NUnit.Framework.Interfaces;

namespace DemoQATestsv2.Tests.Interactions
{
    public class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;
        
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.ScreenShots();
            Driver.Quit();
        }

        [Test]
        public void DroppableMenuTestSimpleTab_When_Dropped()
        {
            _droppablePage.DroppableMenuTestSimpleTab_When_Dropped();

            _droppablePage.Assert_DroppableMenuTestSimpleTab_When_Dropped(_droppablePage.ToBeDraggedBox);
 
        }
        [Test]
        public void DroppableMenuTestSimpleTab_When_Dropped_TextChange()
        {

            _droppablePage.DroppableMenuTestSimpleTab_When_Dropped_TextChange();

            _droppablePage.Assert_DroppableMenuTestSimpleTab_When_Dropped_TextChange(_droppablePage.DroppedBox);

        }
        [Test]
        public void DroppableMenuTestAcceptTab_When_Moved_Accept_Box()
        {
            _droppablePage.DroppableMenuTestAcceptTab_When_Moved_Accept_Box();

            _droppablePage.Assert_DroppableMenuTestAcceptTab_When_Moved_Accept_Box(_droppablePage.DroppedBox);

        }
        [Test]
        public void DroppableMenuTestAcceptTabWhen_Moved_NonAcceptableBoxNOColorChange()
        {
            _droppablePage.DroppableMenuTestAcceptTabWhen_Moved_NonAcceptableBoxNOColorChange();

            _droppablePage.Assert_DroppableMenuTestAcceptTabWhen_Moved_NonAcceptableBoxNOColorChange(_droppablePage.DroppedBox);

        }

    }
}
