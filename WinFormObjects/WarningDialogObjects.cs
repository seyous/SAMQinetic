using FluentAssertions;
using OpenQA.Selenium.Appium.Windows;
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
    public class WarningDialogObjects
    {


        WindowsElement OKbutton => WinDriver.driver.FindElementByName("OK");


        public bool IsSAMOpened()
        {

            WaitForElement.Wait();
            return WinDriver.driver.SessionId != null;
        }

        public bool IsWarningDialogDisplayed()
        {

            var currentWindowHandle = WinDriver.driver.CurrentWindowHandle;
            return OKbutton.Displayed;

        }


        public void OKButtonIsClickedOnWarningDialog()
        {
            try
            {

                WaitForElement.WaitForElementToLoad(OKbutton);

                    OKbutton.Click();


            }
            catch (Exception)
            {

            }
        }
    }
}
