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
    public class WarningDialogObjects : BasePage
    {
        //private readonly Driver _driver;

        public WarningDialogObjects(Driver driver):base(driver)
        {
            _driver = driver;

        }

        WindowsElement OKbutton => _driver.Current.FindElementByName("OK");


        public bool IsSAMOpened()
        {

            Thread.Sleep(TimeSpan.FromSeconds(3));
            return  _driver.Current.SessionId != null;
        }

        public bool IsWarningDialogDisplayed()
        {
            var currentWindowHandle = _driver.Current.CurrentWindowHandle;
            Thread.Sleep(TimeSpan.FromSeconds(5));
            return OKbutton.Displayed;

        }


        public void OKButtonIsClickedOnWarningDialog()
        {
             OKbutton.Click();
        }
    }
}
