using System;
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace SeleniumAdvancedHomeworkTest.QADemoTests.Pages
{
    public abstract class BasePage
    {
        public BasePage(WebDriver driver)
        {
            Driver = driver;
            Driver.WrappedDriver.Manage().Window.Maximize();
            Driver.Navigate("http://www.demoqa.com");
            Wait = new WebDriverWait(Driver.WrappedDriver, TimeSpan.FromSeconds(5));
            Builder = new Actions(Driver.WrappedDriver);
        }

        public virtual string Url { get; }
        public WebDriver Driver { get; }
        public WebDriverWait Wait { get; }
        public Actions Builder { get; set; }

        public void NavigateTo()
        {
            Driver.Navigate(Url);
        }
    }
}


