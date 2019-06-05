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
        WindowsElement pasteRibbonButton => WinDriver.driver.FindElementByName("Item");

        WindowsElement copyRibbonButton => WinDriver.driver.FindElementByName("Copy");
        WindowsElement RenameRibbonButton => WinDriver.driver.FindElementByName("Rename");
        WindowsElement cutRibbonButton => WinDriver.driver.FindElementByName("Cut");
        WindowsElement deleteRibbonButton => WinDriver.driver.FindElementByName("Delete");
        WindowsElement redoRibbonButton => WinDriver.driver.FindElementByName("Redo");
        WindowsElement undoRibbonButton => WinDriver.driver.FindElementByName("Undo");
        WindowsElement autorecalculateRibbonButton => WinDriver.driver.FindElementByName("Item");
        WindowsElement findRibbonButton => WinDriver.driver.FindElementByName("Find");
        WindowsElement showancestryRibbonButton => WinDriver.driver.FindElementByName("Show");
        WindowsElement designexplorerRibbonButton => WinDriver.driver.FindElementByName("Design Explorer");
        WindowsElement graphicsRibbonButton => WinDriver.driver.FindElementByName("Graphics");
        WindowsElement messageRibbonButton => WinDriver.driver.FindElementByName("Item");
        WindowsElement kclpanelRibbonButton => WinDriver.driver.FindElementByName("Item");

        WindowsElement allscenariosRibbonButton => WinDriver.driver.FindElementByName("All Scenarios");
        WindowsElement additionalscenarioRibbonButton => WinDriver.driver.FindElementByName("Additional Scenarios");
        WindowsElement randomscenarioRibbonButton => WinDriver.driver.FindElementByName("Random Scenarios");
        WindowsElement updateResultRibbonButton => WinDriver.driver.FindElementByName("Update Result");
        WindowsElement linktoparamarineRibbonButton => WinDriver.driver.FindElementByName("Link to Paramarine");
        WindowsElement linktoExcelRibbonButton => WinDriver.driver.FindElementByName("Link to Excel");
        WindowsElement traceAnscestorRibbonButton => WinDriver.driver.FindElementByName("Trace Anscestor");
        WindowsElement traceDescendantsRibbonButton => WinDriver.driver.FindElementByName("Trace Descendents");
        WindowsElement helpRibbonButton => WinDriver.driver.FindElementByName("Help");



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

        public bool IsRibbonButtonEnabled(string ribbonObject, string visible)
        {
            WaitForElement.Wait();
            var allWindowHandles = WinDriver.driver.WindowHandles;
            WinDriver.driver.SwitchTo().Window(allWindowHandles[0]);

            var objectstatus = GetRibbon(ribbonObject);

            try
            {
                if (visible != objectstatus.Enabled.ToString())
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

            //switch (objectstatus)
            //{
            //    case 1:
            //        return 


        
        }
    }
}
