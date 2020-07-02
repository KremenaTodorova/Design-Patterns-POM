using NUnit.Framework;
using SeleniumAdvancedHomeworkTest.QADemoTests.Tests;
using DemoQA.QADemoTests.Pages;
using DriverExtesionScroll;

namespace DemoQATestsv2.Tests
{
    
    [TestFixture]
    public class NavigationDemoQA : BaseTest
    {
        private NavigationPage _navigationPage;
        private BaseDemoQAPage _basedemoQAPage;
        

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _navigationPage = new NavigationPage(Driver);
            _basedemoQAPage = new BaseDemoQAPage(Driver);
            _navigationPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ScreenShots();
            Driver.Quit();
        }

       
        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void SuccssesfullyLoadedPage_When_InteractionMenuIsSelected(string sectionName)
        {
            _navigationPage.CategoryButton("Interactions").Click();
            _basedemoQAPage.SubMenu(sectionName).ScrollToElement().ToBeVisible().Click();

            _basedemoQAPage.AssertNavigationIsCorrect(sectionName);
        }
    }
}
