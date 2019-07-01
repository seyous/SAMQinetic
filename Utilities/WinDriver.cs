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

        //private const int implicitTimeoutMs = 120000;

        static string appLocation = @"C:\Program Files\QinetiQ\SAM V2.1\bin\SAM.exe";
        static bool isSAMOpened = false;
        static WindowsElement applicationWindow = null;

        public static WindowsDriver<WindowsElement> OpenDriver()
        {
            //Improved the SAM opening and making it more reliable
            int i = 0;
            isSAMOpened = false;
            while (!isSAMOpened && i <= 2)
            {
                try
                {
                    if (Process.GetProcessesByName("SAM").Length == 0)
                    {

                        Process.Start(appLocation);
                        Thread.Sleep(1000);


                    }

                    Thread.Sleep(5000);

                    if (Process.GetProcessesByName("SAM").Length > 0)
                    {

                        DesiredCapabilities desktopCapabilities = new DesiredCapabilities();
                        desktopCapabilities.SetCapability("platformName", "Windows");
                        desktopCapabilities.SetCapability("app", "Root");

                        desktopCapabilities.SetCapability("deviceName", "WindowsPC");

                        driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desktopCapabilities);

                        var openWindows =
                        driver.FindElementsByAccessibilityId("MainWindow");

                        foreach (var window in openWindows)
                        {

                            if
                            (window.GetAttribute("Name").StartsWith("SAM"))
                            {
                                applicationWindow = window;

                                var topLevelWindowHandle = applicationWindow.GetAttribute("NativeWindowHandle");

                                topLevelWindowHandle =
                                int.Parse(topLevelWindowHandle).ToString("X");

                                DesiredCapabilities capabilities = new
                                DesiredCapabilities();
                                capabilities.SetCapability("deviceName", "WindowsPC");
                                capabilities.SetCapability("appTopLevelWindow", topLevelWindowHandle);

                                driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), capabilities);

                                isSAMOpened = true;
                                return driver;
                            }
                        }

                    }

                }
                catch (Exception ex)
                {
                    Thread.Sleep(5000);
                }

                ++i;
            }

            return driver;

        }






        //    private ExpectedCondition<Boolean> elementFoundAndClicked(By locator)
        //    {
        //        return new ExpectedCondition<Boolean>() {
        //    @Override=

        //    public Boolean apply(WebDriver driver)
        //        {
        //            WebElement el = driver.findElement(locator);
        //            el.click();
        //            return true;
        //        }
        //    };
        //}

        //public void CustomWait()
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));

        //    wait.Until(ElementFoundAndClicked(loginScreen));
        //    wait.until(ExpectedConditions.presenceOfElementLocated(username)).sendKeys(AUTH_USER);
        //    wait.until(ExpectedConditions.presenceOfElementLocated(password)).sendKeys(AUTH_PASS);
        //    wait.until(elementFoundAndClicked(loginBtn));
        //    wait.until(ExpectedConditions.presenceOfElementLocated(getLoggedInBy(AUTH_USER)));
        //}


    }
}
