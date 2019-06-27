using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using SAM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAM.WinFormObjects
{
    public class RibbonValueObjects
         {


        WindowsElement settingsTab => WinDriver.driver.FindElementByName(" Settings");

       //WindowsElement maxcolumnTextbox => WinDriver.driver.FindElementByAccessibilityId("594004");
      // WindowsElement maxcolumnTextbox => WinDriver.driver.FindElementByClassName("WindowsForms10.Window.b.app.0.21093c0_r6_ad1");

        WindowsElement maxcolumnTextbox => WinDriver.driver.FindElementByName("Editing control");

        public void ClickSettingsTab()
        {
            WaitForElement.Wait();
            settingsTab.Click();
        }

        public void PressEnterKey()
        {
            maxcolumnTextbox.SendKeys(Keys.Enter);
        }

        public void EnterNumberValue(string text)
        {
            maxcolumnTextbox.Clear();
            maxcolumnTextbox.SendKeys(text);
        }

        public bool GetValueObject(string valueText)
        {
            if (maxcolumnTextbox.Text.Contains(valueText))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
