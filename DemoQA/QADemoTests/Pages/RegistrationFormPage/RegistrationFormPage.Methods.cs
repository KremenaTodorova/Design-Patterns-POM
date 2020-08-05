using System;
using System.Collections.Generic;
using System.Text;
using DemoQA.QADemoTests.Core;
using DemoQA.QADemoTests.Models;
using DriverExtesionScroll;

namespace DemoQA.QADemoTests.Pages
{
    public partial class RegistrationFormPage : BaseDemoQAPage
    {

        public RegistrationFormPage(WebDriver driver) : base(driver)
        {
        }
        public override string Url => "http://demoqa.com/automation-practice-form";

        public void FillForm(RegistationFormModel user)
        {
            FirstName.SetText(user.FirstName);
            LastName.SetText(user.LastName);
            Email.SetText(user.Email);
            Gender(user.Gender).Click();
            MobilePhone.SetText(user.MobilePhone);

            
        }
    }
}
