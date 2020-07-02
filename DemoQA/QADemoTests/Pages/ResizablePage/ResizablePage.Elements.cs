using System;
using System.Collections.Generic;
using System.Text;
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class ResizablePage
    {
        public WebElement BoxToBeResized => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public WebElement ButtonForResize => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']"));
    }
}
