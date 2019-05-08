using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace SAM
{
    [TestClass]
    public class UnitTest1
    {

        protected static WindowsDriver<WindowsElement> session;


        [TestMethod]
        public void TestMethod1()
        {

            try
            {
                DesiredCapabilities appCapabilities = new DesiredCapabilities();

                appCapabilities.SetCapability("app", @"C:\Program Files\QinetiQ\SAM V2.0\bin\SAM.exe");

                session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);

                var retry = session.FindElementByClassName("Retry");

                retry.Click();
            }
            catch (Exception)
            {

                
            }
        }
    }
}
