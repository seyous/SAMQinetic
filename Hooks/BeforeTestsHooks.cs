using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SAM.Hooks
{
    [Binding]
    public sealed class BeforeTestsHooks
    {
        private static Process _driver;

        [BeforeTestRun]
        public static void StartWinAppDriver()
        {
            try
            {
                _driver = Process.Start(ConfigurationManager.AppSettings["winAppPath"]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not locate WinAppDriver.exe, get it from https://github.com/Microsoft/WinAppDriver/releases and change the winAppPath in app.settings accordingly");
                throw new FileNotFoundException("Could not locate File WinAppDriver.exe", e);
            }
        }

    }
}
