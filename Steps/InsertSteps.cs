using FluentAssertions;
using OpenQA.Selenium;
using SAM.WinFormObjects;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public sealed class InsertSteps
    {

        private readonly ScenarioContext context;
        private readonly InsertFormObject _insertFormObject;

        public InsertSteps(InsertFormObject insertFormObject)
        {

            _insertFormObject = insertFormObject;

        }

        [When(@"the user clicks on ""(.*)""")]
        public void WhenTheUserClicksOn(string p0)
        {

        }


        [Given(@"the user clicks on an ""(.*)""")]
        [When(@"the user clicks on an ""(.*)""")]
        public void GivenTheUserClicksOnAnObject(string objectText)
        {

            if (objectText != null)
            {
                _insertFormObject.ClickOnObject(objectText);
            }
        }

        [Then(@"the insert object ""(.*)"" is displayed")]
        public void ThenTheInsertObjectIsDisplayed(string objectText)
        {
            _insertFormObject.InsertObjectIsDisplayed(objectText)
                .Should().BeTrue("Insert Object is not displayed");

        }

        [When(@"the user rename the object with ""(.*)""")]
        [Given(@"the user rename the object with ""(.*)""")]
        public void GivenTheUserTypeAText(string text)
        {
            _insertFormObject.ChangeObjectText(text);
        }

        [When(@"the user click on the play button on the object")]
        public void WhenTheUserClickOnThePlayButtonOnTheObject()
        {
            _insertFormObject.ClickPlayButton();
        }

        [When(@"the user closes the insert window")]
        public void WhenTheUserClosesTheInsertWindow()
        {
            _insertFormObject.CloseInsertWindow();
        }



        [When(@"the user click on the pencil button on the object")]
        [Given(@"the user click on the pencil button on the object")]
        public void GivenTheUserClickOnThePencilButtonOnTheObject()
        {

            _insertFormObject.ClickPencil();

        }

        [Given(@"the user press the enter key on the keyboard")]
        [When(@"the user press the enter key on the keyboard")]
        public void GivenTheUserPressTheEnterKeyOnTheKeyboard()
        {
            _insertFormObject.ChangeObjectText(Keys.Return);

        }



        [Given(@"the user click the ok button")]
        [When(@"the user click the ok button")]

        public void GivenTheUserClickTheOkButton()
        {
            _insertFormObject.ClickOKButton();
        }



        [Then(@"the ""(.*)"" should be inserted in the design explorer")]
        public void ThenTheShouldBeInsertedInTheDesignExplorer(string objectText)
        {
            _insertFormObject.DesignObjectIsDisplayed(objectText).Should().BeTrue("The Object is not Displayed");
        }
        
    }

}
