using System;
using System.Collections.Generic;
using System.Text;
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class RegistrationFormPage
    {
        public WebElement FirstName => Driver.FindElement(By.XPath("//input[@id='firstName']"));
        public WebElement LastName => Driver.FindElement(By.XPath("//input[@id='lastName']"));
        public WebElement Email => Driver.FindElement(By.XPath("//input[@id='userEmail']"));
        public WebElement Gender(string labelText) =>
           Driver.FindElement(By.XPath($"//*[@id='genterWrapper']//label[text()='{labelText}']"));
        public WebElement MobilePhone => Driver.FindElement(By.XPath("//input[@id='userNumber']"));
     
        public WebElement Hobby => Driver.FindElement(By.XPath("//*[@id='hobbiesWrapper']/div[2]/div[3]/label"));
        public WebElement SubmitButton => Driver.FindElement(By.XPath("//div[@class='col-12 mt-4 col-md-3']"));
    }
}
