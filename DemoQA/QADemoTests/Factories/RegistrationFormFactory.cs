using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using DemoQA.QADemoTests.Models;

namespace DemoQA.QADemoTests.Factories
{
    public static class RegistrationFormFactory
    {
        public static RegistationFormModel CreateValidUser()
        {
            var fixture = new Fixture();

            return new RegistationFormModel
            {
                FirstName = fixture.Create<string>(),
                LastName = fixture.Create<string>(),
                Gender = Gender.Male.ToString(),
                Email = fixture.Create<string>(),
                MobilePhone = fixture.Create<string>(),
                
            };
        }
    }
}
