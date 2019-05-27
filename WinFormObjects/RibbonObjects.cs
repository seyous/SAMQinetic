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


        public void ClickInsertButton()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var allWindowHandles = _driver.Current.WindowHandles;
            _driver.Current.SwitchTo().Window(allWindowHandles[0]);
            insertRibbonButton.Click();

        }
    }
}
