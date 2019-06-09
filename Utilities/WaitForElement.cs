using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.Utilities
{
    public static class WaitForElement
    {
        public static bool WaitForElementToLoad(WindowsElement element)
        {

            for (int i = 1; i <= 20; i++)
            {
                if (IsElementDisplayed(element))
                {
                    return true;
                }
                WaitForElement.Wait();

            }

            return false;

        }

        public static bool IsElementDisplayed(WindowsElement element)
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

        public static void Wait()
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }

    }
}
