using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace SAM
{
    //[TestClass]
    public class UnitTest1
    {

        //protected static WindowsDriver<WindowsElement> session;
        private const int implicitTimeoutMs = 120000;

        //WindowsDriver<RemoteWebElement> session1;
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
                Thread.Sleep(TimeSpan.FromSeconds(10));

            }
            catch (Exception)
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));

                session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities, TimeSpan.FromMinutes(3));
                Thread.Sleep(TimeSpan.FromSeconds(10));

            }


            session.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));

            Thread.Sleep(TimeSpan.FromSeconds(10));
            Assert.IsNotNull(session);

            var currentWindowHandle = session.CurrentWindowHandle;
            Thread.Sleep(TimeSpan.FromSeconds(7));
            session.FindElementByName("OK").Click();

            // Wait for 5 seconds or however long it is needed for the right window to appear/for the splash screen to be dismissed
            Thread.Sleep(TimeSpan.FromSeconds(5));
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



            // appCapabilities.SetCapability("app", appLocation);

            try
            {
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), desktopCapabilities);

            }
            catch (Exception)
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));

                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), desktopCapabilities);

            }
            Assert.IsNotNull(session);

           
            /*


             string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

             DesiredCapabilities desktopCapabilities = new DesiredCapabilities();

             WindowsDriver<WindowsElement> AppSession;

             WindowsDriver<WindowsElement> DesktopSession;




             try
             {
                         AppSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), desktopCapabilities, TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));
                         // AppSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), (DesiredCapabilities) appCapabilities, TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));

                         AppSession.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));

                     }
                     catch (Exception e)
                     {
                         // Create a session for Desktop
                         //DesiredCapabilities desktopCapabilities = new DesiredCapabilities();
                         desktopCapabilities.SetCapability("app", appLocation);
                         //desktopCapabilities.SetCapability("platformName", "Windows");
                         //desktopCapabilities.SetCapability("deviceName", "WindowsPC");
                         DesktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), desktopCapabilities, TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));
                         Assert.IsNotNull(DesktopSession);

                         //Launch Cortana Window using Windows Key +S keyboard shortcut to allow session creation to find it
                         DesktopSession.FindElementByName("Search Windows").Click();
                         //DesktopSession.Keyboard.SendKeys(OpenQA.Selenium.Keys.Meta + "s" + OpenQA.Selenium.Keys.Meta);
                         DesktopSession.Keyboard.SendKeys("{TestedApp}");
                         DesktopSession.FindElementByName("{TestedApp}, Windows app").Click();
                         Thread.Sleep(TimeSpan.FromSeconds(1));
                         WindowsElement TestedAppWindow = DesktopSession.FindElementByName("{TestedApp}");
                         String TestedAppTopLevelWindowHandle = TestedAppWindow.GetAttribute("NativeWindowHandle");
                         TestedAppTopLevelWindowHandle = (int.Parse(TestedAppTopLevelWindowHandle)).ToString("x");

                         // Create session for already running app
                         DesiredCapabilities appCapabilities1 = new DesiredCapabilities();
                         appCapabilities1.SetCapability("appTopLevelWindow", TestedAppTopLevelWindowHandle);
                         AppSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities1);
                         Assert.IsNotNull(AppSession);
                     }
 */

            /*
            WindowsDriver<WindowsElement> AppSession;

            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platormName", "Windows");
            capabilities.SetCapability("deviceName", "WindowsPC");
            capabilities.SetCapability("app", appLocation);
            //capabilities.SetCapability("appArguments", xx);

            try
            {

                AppSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            }
            catch (Exception e) { }

            //1. Creating a Desktop session
            DesiredCapabilities desktopCapabilities = new DesiredCapabilities();
            desktopCapabilities.SetCapability("platormName", "Windows");
            desktopCapabilities.SetCapability("app", "Root");
            desktopCapabilities.SetCapability("deviceName", "WindowsPC");
            AppiumDriver<WindowsElement> DesktopSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub"), desktopCapabilities);
            
            //Thread.sleep(3000);
            WebElement XXXWindow = DesktopSession.findElementByName("XXX XXX");

            //2. Attaching to existing XXX XXX Window
            String XXXTopLevelWindowHandle = XXXWindow.getAttribute("NativeWindowHandle");
            XXXTopLevelWindowHandle = Integer.toHexString(Integer.parseInt(XXXTopLevelWindowHandle));

            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.setCapability("deviceName", "WindowsPC");
            appCapabilities.setCapability("appTopLevelWindow", XXXTopLevelWindowHandle);
            driver = new WindowsDriver(new URL("http://127.0.0.1:4723/wd/hub"), appCapabilities);

            */
        }
    }
}
