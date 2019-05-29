using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SAM.Hooks
{
    [Binding]
    public sealed class AfterTestsHooks
    {
        private static Process _driver;

        [AfterTestRun]
        [AfterScenario]
        public static void KillWinAppDriver()
        {
//            _driver.Kill();

            try
            {
                foreach (Process proc in Process.GetProcessesByName("SAM"))
                {
                    //proc.Kill();
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
