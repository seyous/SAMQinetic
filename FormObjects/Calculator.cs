using SAM.Utilities;

namespace SAM.Helper
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Calculator
    {
        private readonly Driver _driver;

        public Calculator(Driver driver)
        {
            _driver = driver;

        }

        public void EnterNumber(string number)
        {
            foreach (char c in number)
            {
                _driver.Calc.FindElementByAccessibilityId("num" + c + "Button").Click();
            }
        }

        public void EnterSign(string sign)
        {
            _driver.Calc.FindElementByAccessibilityId(sign + "Button").Click();
        }

        public void NavigateToStandard()
        {
            _driver.Calc.FindElementByAccessibilityId("NavButton").Click();
            _driver.Calc.FindElementByAccessibilityId("FlyoutNav").FindElementsByClassName("ListViewItem")[0].Click();
        }

        public string GetTitle()
        {
            return _driver.Calc.FindElementByAccessibilityId("Header").Text.Trim();
        }


        public string GetResult()
        {
            return _driver.Calc.FindElementByAccessibilityId("CalculatorResults").Text.Trim().Replace("Display is ", "");
        }
    }
}