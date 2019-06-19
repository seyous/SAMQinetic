﻿using OpenQA.Selenium;
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
            //Improved the SAM opening and making it more reliable

            /*
 
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
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));


                }
                catch (Exception)
                {
                    WaitForElement.Wait();


                    if (driver != null)
                    {
                        return driver;
                    }


                    WaitForElement.Wait();
                    driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), capabilities, TimeSpan.FromMinutes(5));
                    WaitForElement.Wait();
                    driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Convert.ToDouble(implicitTimeoutMs)));

                }


            */



            WindowsElement applicationWindow = null;
            try
            {

                int i = 0;
                bool isSAMOpened = false;
                Process.Start(@"C:\Program Files\QinetiQ\SAM V2.1\bin\SAM.exe");

                while (!isSAMOpened && i <= 3)
                {

                    DesiredCapabilities desktopCapabilities = new DesiredCapabilities();
                    desktopCapabilities.SetCapability("platformName",
                    "Windows");
                    desktopCapabilities.SetCapability("app", "Root");

                    desktopCapabilities.SetCapability("deviceName",
                    "WindowsPC");

                    driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desktopCapabilities);

                    var openWindows =
                    driver.FindElementsByAccessibilityId("MainWindow");



                    foreach (var window in openWindows)
                    {

                        if
               (window.GetAttribute("Name").StartsWith("SAM"))
                        {
                            applicationWindow = window;
                            isSAMOpened = true;
                            break;
                        }
                    } //

                    i++;

                }




                //driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Enter);


                // driver.Keyboard.PressKey(OpenQA.Selenium.Keys.Command + "a" + OpenQA.Selenium.Keys.Command);


                var topLevelWindowHandle = applicationWindow.GetAttribute("NativeWindowHandle");

                //driver.FindElementByName("Insert").Click();




                topLevelWindowHandle =
                int.Parse(topLevelWindowHandle).ToString("X");

                DesiredCapabilities capabilities = new
                DesiredCapabilities();
                capabilities.SetCapability("deviceName", "WindowsPC");
                capabilities.SetCapability("appTopLevelWindow", topLevelWindowHandle);

                driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities);
            }
            catch (Exception ex)
            {

            }


            return driver;
            
        }



        public static void WaitForElements(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));

            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));

        }

        /*

        private ExpectedCondition<Boolean> elementFoundAndClicked(By locator)
        {
            return new ExpectedCondition<Boolean>() {
        @Override
        
        public Boolean apply(WebDriver driver)
            {
                WebElement el = driver.findElement(locator);
                el.click();
                return true;
            }
        };
    }
    
    public void testLogin_CustomWait()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));

        wait.Until(ElementFoundAndClicked(loginScreen));
        wait.until(ExpectedConditions.presenceOfElementLocated(username)).sendKeys(AUTH_USER);
        wait.until(ExpectedConditions.presenceOfElementLocated(password)).sendKeys(AUTH_PASS);
        wait.until(elementFoundAndClicked(loginBtn));
        wait.until(ExpectedConditions.presenceOfElementLocated(getLoggedInBy(AUTH_USER)));
    }
    */

}
}
