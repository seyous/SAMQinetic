using OpenQA.Selenium.Remote;
using SAM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SAM.FormObjects
{
    public class RibbonObjects
    {
        private readonly Driver _driver;

        public RibbonObjects(Driver driver)
        {
            _driver = driver;

        }
        public void ClickInsertButton()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            var allWindowHandles = _driver.Current.WindowHandles;
            _driver.Current.SwitchTo().Window(allWindowHandles[0]);
            _driver.Current.FindElementByName("Insert").Click();

        }
    }
}
