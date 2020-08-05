using DemoQA.QADemoTests.Factories;
using DemoQA.QADemoTests.Models;
using DemoQA.QADemoTests.Pages;
using DriverExtesionScroll;
using NUnit.Framework;
using SeleniumAdvancedHomeworkTest.QADemoTests.Tests;

namespace DemoQA.QADemoTests.Tests
{
    [TestFixture]
    public class RegistrationForm : BaseTest
    {
        private RegistrationFormPage _registrationFormPage;
        private RegistationFormModel _user;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _registrationFormPage = new RegistrationFormPage(Driver);
            _user = RegistrationFormFactory.CreateValidUser();
            _registrationFormPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ScreenShots();
            Driver.Quit();
        }
        [Test]
        public void Fill_RegistrationForm_When_All_Data_Is_Valid()
        {
            _registrationFormPage.FillForm(_user);
            _registrationFormPage.Hobby.ScrollToElement().ToBeVisible().Click();
            _registrationFormPage.SubmitButton.ScrollToElement().ToBeVisible().Click();
        }

    }

}
