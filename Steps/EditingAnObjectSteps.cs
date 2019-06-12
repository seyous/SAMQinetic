using FluentAssertions;
using OpenQA.Selenium;
using SAM.WinFormObjects;
using System;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class EditingAnObjectSteps
        {

        private readonly InsertFormObject _insertFormObject;

        public EditingAnObjectSteps(InsertFormObject insertFormObject)
        {
            _insertFormObject = insertFormObject;
        }


        [Given(@"the user click on the minus button on the object")]
        public void GivenTheUserClickOnTheMinusButtonOnTheObject()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the user press function key on the keyboard")]
        [When(@"the user press function key on the keyboard")]
        public void GivenTheUserPressFOnTheKeyboard()
        {
            _insertFormObject.ChangeObjectTextOnKeyPress();
            _insertFormObject.ClearText();
            
        }
        
        [Given(@"the user click anywhere in the window")]
        public void GivenTheUserClickAnywhereInTheWindow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the user press the escape key")]
        [When(@"the user press the escape key")]
        public void GivenTheUserPressTheEscapeKey()
        {
            _insertFormObject.ChangeObjectText(Keys.Escape);
        }
        
        [Then(@"the name of the object is reverted to object")]
        public string ThenTheNameOfTheObjectIsRevertedToObject(string text)
        {
            text = _insertFormObject.GetTextOnInsertObject();

            if(text =="geom placeholder")
            {
                return text;
            }
            else
            {
                return null;
            }
        }
        
        [Then(@"the user click the cancel button")]
        public void ThenTheUserClickTheCancelButton()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
