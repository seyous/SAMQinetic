using OpenQA.Selenium.Appium.Windows;
using SAM.Base;
using SAM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAM.WinFormObjects
{
    public class DesignExplorerObjects : BasePage
    {
        public DesignExplorerObjects(Driver driver) : base(driver)
        {
            _driver = driver;

        }

        WindowsElement OKButton => WinDriver.driver.FindElementByName("OK");
        public WindowsElement GetWindowsElementByName(string name)
        {
            return WinDriver.driver.FindElementByName(name);
        }
    }
}
