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
        WindowsElement layoutTab => WinDriver.driver.FindElementByName(" Layout");
        WindowsElement SAMTab => WinDriver.driver.FindElementByName(" SAM");

        WindowsElement TempLocationTab => WinDriver.driver.FindElementByName("Temp Location");


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

        public void ClickLayoutTab()
        {
            WaitForElement.Wait();
        var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
            layoutTab.Click();
        }


        public void ClickSAMTab()
        {
            WaitForElement.Wait();
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
            SAMTab.Click();
        }

       
        public void ClickTempLocationTab()
        {
            WaitForElement.Wait();
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
            TempLocationTab.Click();
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

      
    }
}
