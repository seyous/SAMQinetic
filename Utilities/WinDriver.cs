using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.Utilities
{
    public static class WinDriver
    {
        private static  WindowsDriver<WindowsElement> _driver;

        private const int implicitTimeoutMs = 120000;

        static string appLocation = @"C:\Program Files\QinetiQ\SAM V2.1\bin\SAM.exe";

        public static WindowsDriver<WindowsElement> OpenDriver()
        {

 
                if (_driver != null)
                {
                    return _driver;
                }

                var capabilities = new DesiredCapabilities();
                capabilities.SetCapability("app", appLocation);
                try
                {
                    _driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), capabilities, TimeSpan.FromMinutes(2));
                WaitForElement.Wait();

            }
            catch (Exception)
                {
                WaitForElement.Wait();

                _driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), capabilities, TimeSpan.FromMinutes(2));
                WaitForElement.Wait();

            }
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));


                return _driver;
            
        }
    }
}
