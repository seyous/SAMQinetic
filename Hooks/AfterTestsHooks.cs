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

        [AfterScenario]
        [AfterTestRun]
        public static void KillWinAppDriver()
        {

            try
            {
                foreach (Process proc in Process.GetProcessesByName("SAM"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
