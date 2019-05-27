using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using SAM.Base;
using SAM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.WinFormObjects
{
    public class RibbonObjects :BasePage
    {
        public RibbonObjects(Driver driver):base(driver)
        {
            _driver = driver;
        }

        
        WindowsElement insertRibbonButton => _driver.Current.FindElementByName("Insert");

        WindowsElement helpRibbonButton => _driver.Current.FindElementByName("Help");

        WindowsElement propertiesRibbonButton => _driver.Current.FindElementByName("Properties");


        public WindowsElement GetRibbon(string ribbonName)
        {
            return _driver.Current.FindElementByName(ribbonName);
        }

        public void ClickInsertButton()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var allWindowHandles = _driver.Current.WindowHandles;
            _driver.Current.SwitchTo().Window(allWindowHandles[0]);

            insertRibbonButton.Click();

        }




        public bool IsRibbonButtonDisplayed(string ribbonText)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var allWindowHandles = _driver.Current.WindowHandles;
            _driver.Current.SwitchTo().Window(allWindowHandles[0]);
            return GetRibbon(ribbonText).Displayed;

        }
    }
}
