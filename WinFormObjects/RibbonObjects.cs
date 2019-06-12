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
    public class RibbonObjects 
    {
        //public RibbonObjects(Driver driver):base(driver)
        //{
        //    _driver = driver;
        //}

        
        WindowsElement insertRibbonButton => WinDriver.driver.FindElementByName("Insert");
        WindowsElement propertiesRibbonButton => WinDriver.driver.FindElementByName("Properties");


        public WindowsElement GetRibbon(string ribbonName)
        {

            return WinDriver.driver.FindElementByName(ribbonName);
        }

        public void ClickInsertButton()
        {
            WaitForElement.Wait();
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);

            insertRibbonButton.Click();
        }


        public bool IsRibbonButtonDisplayed(string ribbonText)
        {
            WaitForElement.Wait();
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
            return GetRibbon(ribbonText).Displayed;
        }

        public bool IsRibbonButtonEnabled(string ribbonName, string visibility)
        {
           
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);

            var objectstatus = GetRibbon(ribbonName);

            try
            {
                if (visibility == "Enabled")
                {

                    return objectstatus.Enabled;
                }
                else if (visibility=="Disabled")
                {
                    return !objectstatus.Enabled;
                }
            }
            catch (Exception)
            {

                return false;
            }
            return false;
                  
        }

       // public int boundaryvalue (string ribbonName, int minimumvalue, int maximumvalue)
        //{
        //    var ribbon = WinDriver.driver.FindElementByName(ribbonName);
        //    ribbon.SendKeys("maximumvalue");
            
        //} 
    }
}
