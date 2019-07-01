using FluentAssertions;
using SAM.WinFormObjects;
using System;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class SelectingObjectSteps
    {

        private readonly InsertFormObject _insertFormObject;
        public SelectingObjectSteps(InsertFormObject insertFormObject)
        {
            _insertFormObject = insertFormObject;
        }

        [When(@"the user hover the mouse and click on an ""(.*)""")]
        public void WhenTheUserHoverTheMouseAndClickOnAn(string formObject)
        {
            _insertFormObject.MouseHoverOnObject(formObject);
        }



        [Then(@"the user confirms the object is selected in bold font")]
        public void ThenTheUserConfirmsTheObjectSelectedInBoldFont()
        {
            _insertFormObject.SelectedObjectIsBold().Should().BeTrue("The objected is not selected");
        }
    }
}
