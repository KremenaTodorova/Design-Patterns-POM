using System;
using System.Collections.Generic;
using System.Text;
using DemoQA.QADemoTests.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.QADemoTests.Pages
{
    public partial class DroppablePage
    {


        public void Assert_DroppableMenuTestSimpleTab_When_Dropped(WebElement element)
        {

            Assert.AreNotSame(element.Location.Y, 260);
            Assert.AreNotSame(element.Location.X, 76);
        }
        public void Assert_DroppableMenuTestSimpleTab_When_Dropped_TextChange(WebElement element)
        {

            Assert.AreEqual(element.Text, "Dropped!");
        }
        public void Assert_DroppableMenuTestAcceptTab_When_Moved_Accept_Box(WebElement element)
        {

            Assert.AreNotEqual("rgb(70, 130, 180)", element.GetCssValue("color"));

        }
        public void Assert_DroppableMenuTestAcceptTabWhen_Moved_NonAcceptableBoxNOColorChange(WebElement element)
        {

            Assert.AreNotEqual("rgba(73, 80, 87, 1)", element.GetCssValue("color"));

        }

    }
}
