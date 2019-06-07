using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.Utilities
{
    public static class WinDriver
    {
        public static  WindowsDriver<WindowsElement> driver;

        private const int implicitTimeoutMs = 120000;

        static string appLocation = @"C:\Program Files\QinetiQ\SAM V2.1\bin\SAM.exe";
        
        public static WindowsDriver<WindowsElement> OpenDriver()
        {

 
                if (driver != null)
                {
                    return driver;
                }

                var capabilities = new DesiredCapabilities();
                capabilities.SetCapability("app", appLocation);
                try
                {
                    driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities, TimeSpan.FromMinutes(10));
                    WaitForElement.Wait();
                Thread.Sleep(15000);
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));


                }
                catch (Exception)
                {
                WaitForElement.Wait();
                WaitForElement.Wait();


                if (driver != null)
                {
                    return driver;
                }


                WaitForElement.Wait();
                driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), capabilities, TimeSpan.FromMinutes(15));
                WaitForElement.Wait();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));

            }


            return driver;
            
        }



        public static void WaitForElements(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));

            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));

        }
    }
}
