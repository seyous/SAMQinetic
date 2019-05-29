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

        [Given(@"the user clicks on an ""(.*)""")]
        [When(@"the user clicks on an ""(.*)""")]
        public void GivenTheUserClicksOnAnObject(string objectText)
        {
            _insertFormObject.ClickOnObject(objectText);

        }

        [Then(@"the insert object ""(.*)"" is displayed")]
        public void ThenTheInsertObjectIsDisplayed(string objectText)
        {
            _insertFormObject.InsertObjectIsDisplayed(objectText)
                .Should().BeTrue("Insert Object is not displayed");

        }

        [When(@"the user type ""(.*)""")]
        [Given(@"the user type ""(.*)""")]
        public void GivenTheUserTypeAText(string text)
        {
            _insertFormObject.ChangeObjectText(text);
        }

        [When(@"the user click on the pencil button on the object")]
        [Given(@"the user click on the pencil button on the object")]
        public void GivenTheUserClickOnThePencilButtonOnTheObject()
        {



            _insertFormObject.ClickPencil();
            _insertFormObject.ClickPencil();

            _insertFormObject.ClickPencil();


            _insertFormObject.ClickPencil();

            _insertFormObject.ClickPencil();

            _insertFormObject.ClickPencil();

            _insertFormObject.ClickPencil();

            _insertFormObject.ClickPencil();

        }

        [Given(@"the user press the enter key on the keyboard")]
        public void GivenTheUserPressTheEnterKeyOnTheKeyboard()
        {
            _insertFormObject.ChangeObjectText(Keys.Enter);
        }

        [Given(@"the user click the ok button")]
        public void GivenTheUserClickTheOkButton()
        {
            _insertFormObject.ClickOKButton();
        }


        [Then(@"the object should be inserted in the design explorer")]
        public void ThenTheObjectShouldBeInsertedInTheDesignExplorer()
        {

        }


    }
}
