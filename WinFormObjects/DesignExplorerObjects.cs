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
    public class DesignExplorerObjects
    {
        


        public bool IsElementInExplorerWindow()
        {
            WindowsElement element = WinDriver.driver.FindElementByName("treeListColumn1 row 1");
            WaitForElement.WaitForElementToLoad(element);
            return element.Displayed;
        }

        
    }
}
