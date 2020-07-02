using System;
using System.Collections.Generic;
using System.Text;
using DemoQA.QADemoTests.Core;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial  class DraggablePage
    {


        public WebElement DraggableAxisButton => Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-axisRestriction']"));

        public WebElement RestrictedXButton => Driver.FindElement(By.Id("restrictedX"));

        public WebElement RestrictedYButton => Driver.FindElement(By.Id("restrictedY"));

        public WebElement ContainerRestrictedButton => Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-containerRestriction']"));

        public WebElement ContainerWithinBox => Driver.FindElement(By.XPath("//*[@id='containmentWrapper']/div"));

        public WebElement ContainerWrapper => Driver.FindElement(By.XPath("//div[@id='containmentWrapper']"));
    }
}
