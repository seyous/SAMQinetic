using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow.Configuration;


namespace SAM.Utilities
{
    public class Driver// : IDisposable
    {
        private WindowsDriver<WindowsElement> _driver;
        private const int implicitTimeoutMs = 120000;

        string appLocation = @"C:\Program Files\QinetiQ\SAM V2.1\bin\SAM.exe";

        public WindowsDriver<WindowsElement> Current
        {

            get
            {
                if (_driver != null)
                {
                    return _driver;
                }

                var capabilities = new DesiredCapabilities();
                capabilities.SetCapability("app", appLocation);

                try
                {
                 _driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), capabilities, TimeSpan.FromMinutes(5));
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

        public WindowsDriver<WindowsElement> Calc
        {
            get
          {
                if (_driver != null)
                {
                    return _driver;
                }

                var capabilities = new DesiredCapabilities();
                capabilities.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
                _driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), capabilities);

                return _driver;
            }
        }

    }
}


