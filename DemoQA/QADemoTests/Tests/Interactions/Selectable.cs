using DemoQA.QADemoTests.Pages;
using NUnit.Framework;
using SeleniumAdvancedHomeworkTest.QADemoTests.Tests;


namespace DemoQATestsv2.Tests.Interactions
{
    public class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateTo();

        }
        [TearDown]
        public void TearDown()
        {
            Driver.ScreenShots();
            Driver.Quit();
        }

        [Test]
        public void SelectableMenuTests_When_Select()
        {

            _selectablePage.SelectableTests_When_Selected();

            _selectablePage.Assert_When_SelectableIsSelected(_selectablePage.FirstTextButton, _selectablePage.LastTextButton);
        }

        [Test]
        public void SelectableMenuSelect_When_Unselect()
        {
            _selectablePage.SelectableTests_When_UnSelected();

            _selectablePage.Assert_When_SelectableIsSelected_Unselected(_selectablePage.LastTextButton);


        }
    }
}
