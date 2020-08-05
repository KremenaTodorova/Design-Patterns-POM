using System;
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DriverExtesionScroll
{
    public static class DriverExtension
    {
        public static WebElement ScrollToElement(this WebElement element)
        {
            ((IJavaScriptExecutor)element.WrappedDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element.WrappedElement);
            return element;
        }

        public static WebElement ToBeVisible(this WebElement element)
        {
            var wait = new WebDriverWait(element.WrappedDriver, TimeSpan.FromSeconds(20));
            IWebElement nativeWebElement =
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element.By));

            return element;
        }

    }

}
