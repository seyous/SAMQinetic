using SAM.WinFormObjects;
using System;
using TechTalk.SpecFlow;

namespace SAM
{
    [Binding]
    public class ValidateNumberBoundarySteps
    {

        private readonly RibbonObjects _ribbon;

        public ValidateNumberBoundarySteps(RibbonObjects ribbon)
        {
            ribbon = ribbon;
        }
       

        [Then(@"the ribbon ""(.*)"" value is '(.*)' and  '(.*)'")]
        public void ThenTheRibbonValueIsAnd(string ribbonName, int minimumvalue, int maximumvalue)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
