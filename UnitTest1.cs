using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using SAM.Utilities;

namespace SAM
{
    //[TestClass]
    public class UnitTest1
    {

        private const int implicitTimeoutMs = 120000;
        WindowsDriver<WindowsElement> session;
        private static Process _driver;


        [TestMethod]
        public void NotepadTest()
        {
            WindowsDriver<WindowsElement> NotepadSession;

            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", @"C:\Windows\System32\notepad.exe");
            NotepadSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
            // Control the AlarmClock app
            NotepadSession.FindElementByClassName("Edit").SendKeys("This is some text");
        }

        [TestMethod]
        public void SamTest()
        {
            WindowsDriver<WindowsElement> SAMSession;

            string appLocation = @"C:\Program Files\QinetiQ\SAM V2.1\bin\SAM.exe";
            
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", appLocation);

            try
            {
                session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities, TimeSpan.FromMinutes(3));
                WaitForElement.Wait();

            }
            catch (Exception)
            {
                WaitForElement.Wait();

                session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities, TimeSpan.FromMinutes(3));
                WaitForElement.Wait();

            }


            session.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));

            WaitForElement.Wait();
            Assert.IsNotNull(session);

            var currentWindowHandle = session.CurrentWindowHandle;
            WaitForElement.Wait();

            session.FindElementByName("OK").Click();

            WaitForElement.Wait();
            var allWindowHandles = session.WindowHandles;
            session.SwitchTo().Window(allWindowHandles[0]);
            session.FindElementByName("Insert").Click();
            
        }


        [TestMethod]
        public void SamTest1()
        {
    
            string appLocation = @"C:\Program Files\QinetiQ\SAM V2.0\bin\SAM.exe";



            DesiredCapabilities desktopCapabilities = new DesiredCapabilities();
            
            string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";


            desktopCapabilities.SetCapability("app", appLocation);
            desktopCapabilities.SetCapability("platformName", "Windows");
            desktopCapabilities.SetCapability("deviceName", "WindowsPC");




            try
            {
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), desktopCapabilities);

            }
            catch (Exception)
            {
                WaitForElement.Wait();

                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), desktopCapabilities);

            }
            Assert.IsNotNull(session);


           
        }
    }
}
