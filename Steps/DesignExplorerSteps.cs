using SAM.WinFormObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class DesignExplorerSteps
    {
        DesignExplorerObjects designExplorerObjects = new DesignExplorerObjects();

        [Then(@"the object should be inserted in the design explorer")]
        public void ThenTheObjectShouldBeInsertedInTheDesignExplorer()
        {
            designExplorerObjects.IsElementInExplorerWindow();

            Thread.Sleep(20000);
        }
    }
}
