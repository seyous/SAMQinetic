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

        
        WindowsElement insertRibbonButton => WinDriver.driver.FindElementByName("Insert");
        WindowsElement propertiesRibbonButton => WinDriver.driver.FindElementByName("Properties");
        WindowsElement layoutTab => WinDriver.driver.FindElementByName(" Layout");
        WindowsElement SAMTab => WinDriver.driver.FindElementByName(" SAM");

        WindowsElement TempLocationTab => WinDriver.driver.FindElementByName("Temp Location");
        WindowsElement FileTab => WinDriver.driver.FindElementByName("The BackstageViewControl");

        
        public WindowsElement GetRibbon(string ribbonName)
        {
            return WinDriver.driver.FindElementByName(ribbonName);
        }

        public void ClickInsertButton()
        {

            for (int i = 0; i < 5; i++)
            {

                try
                {
                    var allWindowHandles = WinDriver.driver.WindowHandles;
                    WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
                    WaitForElement.WaitForElementToLoad(insertRibbonButton);

                    insertRibbonButton.Click();
                    break;
                }
                catch (Exception ex)
                {
                    WinDriver.driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Escape);
                    WinDriver.driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Escape);
                }
            }

        }

        //WaitForElement.Wait();
        //    var allWindowHandles = WinDriver.driver.WindowHandles;
        //    WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
        //    insertRibbonButton.Click();
        //}

        public void ClickLayoutTab()
        {
            WaitForElement.WaitForElementToLoad(layoutTab);
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
            layoutTab.Click();
        }

        public void ClickFileTab()
        {
            WaitForElement.WaitForElementToLoad(layoutTab);
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
            FileTab.Click();

        }


        public void ClickSAMTab()
        {
            WaitForElement.WaitForElementToLoad(SAMTab);
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
            SAMTab.Click();
        }

       
        public void ClickTempLocationTab()
        {
            for (int i = 1; i < 5; i++)
            {
                try
                {
                    WaitForElement.Wait();
                    var allWindowHandles = WinDriver.driver.WindowHandles;
                    WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);
                    TempLocationTab.Click();
                    break;
                }
                catch (Exception)
                {

                    throw;
                }
            }
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
            bool visible = false;

                WaitForElement.Wait();
                try
                {
                    var allWindowHandles = WinDriver.driver.WindowHandles;
                    WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);

                    visible= GetRibbon(ribbonName).Enabled;
                }
                catch (Exception e)
                {
                     visible = false;
                }

                if (visibility == "Enabled")
                {

                    return visible;             
                }
                else if (visibility == "Disabled" )
                {
                    return !visible;
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
