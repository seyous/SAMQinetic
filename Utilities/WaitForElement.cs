using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.Utilities
{
    public class WaitForElement
    {
        public bool WaitForElementToLoad(WindowsElement element)
        {

            for (int i = 1; i <= 20; i++)
            {
                if (IsElementDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(500);
            }

            return false;

        }

        public bool IsElementDisplayed(WindowsElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch
            {
                return false;
            }

        }



    }
}
