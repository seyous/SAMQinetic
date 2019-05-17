using FluentAssertions;
using SAM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.Helper
{
    public class WarningDialogObjects
    {
        private readonly Driver _driver;

        public WarningDialogObjects(Driver driver)
        {
            _driver = driver;

        }

        public bool IsSAMOpened()
        {

            Thread.Sleep(TimeSpan.FromSeconds(10));
            return _driver.Current.SessionId != null;
        }

        public bool IsWarningDialogDisplayed()
        {
            var currentWindowHandle = _driver.Current.CurrentWindowHandle;
            Thread.Sleep(TimeSpan.FromSeconds(10));
            return _driver.Current.FindElementByName("OK").Displayed;

        }


        public void OKButtonIsClickedOnWarningDialog()
        {
             _driver.Current.FindElementByName("OK").Click();
        }
    }
}
