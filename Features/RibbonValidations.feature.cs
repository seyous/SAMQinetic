﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SAM.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RibbonValidations")]
    public partial class RibbonValidationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RibbonValidations.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RibbonValidations", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Home Ribbon is Displayed")]
        [NUnit.Framework.CategoryAttribute("Ribbon")]
        [NUnit.Framework.TestCaseAttribute("Paste", null)]
        [NUnit.Framework.TestCaseAttribute("Undo", null)]
        [NUnit.Framework.TestCaseAttribute("Redo", null)]
        [NUnit.Framework.TestCaseAttribute("Cut", null)]
        [NUnit.Framework.TestCaseAttribute("Delete", null)]
        [NUnit.Framework.TestCaseAttribute("Rename", null)]
        public virtual void HomeRibbonIsDisplayed(string ribbon, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Ribbon"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Home Ribbon is Displayed", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
testRunner.Given("a user opens SAM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
testRunner.When("the warning message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
testRunner.Then("the user can click on the OK button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
testRunner.And(string.Format("the ribbon \"{0}\" is displayed", ribbon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Home Ribbon AutoRecal is Displayed")]
        [NUnit.Framework.TestCaseAttribute("Auto Recalculate", null)]
        public virtual void HomeRibbonAutoRecalIsDisplayed(string ribbon, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Home Ribbon AutoRecal is Displayed", null, exampleTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
testRunner.Given("a user opens SAM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
testRunner.When("the warning message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
testRunner.Then("the user can click on the OK button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
testRunner.And(string.Format("the ribbon \"{0}\" is displayed", ribbon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Home Ribbon Block Action is Displayed")]
        [NUnit.Framework.CategoryAttribute("Ribbon")]
        [NUnit.Framework.TestCaseAttribute("Insert", null)]
        [NUnit.Framework.TestCaseAttribute("Find", null)]
        [NUnit.Framework.TestCaseAttribute("Properties", null)]
        [NUnit.Framework.TestCaseAttribute("Tabular View", null)]
        [NUnit.Framework.TestCaseAttribute("Object Setup", null)]
        [NUnit.Framework.TestCaseAttribute("Move Up", null)]
        [NUnit.Framework.TestCaseAttribute("Move Down", null)]
        [NUnit.Framework.TestCaseAttribute("Force Recalculate", null)]
        [NUnit.Framework.TestCaseAttribute("Protect", null)]
        [NUnit.Framework.TestCaseAttribute("Units", null)]
        [NUnit.Framework.TestCaseAttribute("Show Ancestry", null)]
        [NUnit.Framework.TestCaseAttribute("Level", null)]
        public virtual void HomeRibbonBlockActionIsDisplayed(string ribbon, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Ribbon"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Home Ribbon Block Action is Displayed", null, @__tags);
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
testRunner.Given("a user opens SAM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
testRunner.When("the warning message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
testRunner.Then("the user can click on the OK button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
testRunner.And(string.Format("the ribbon \"{0}\" is displayed", ribbon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Home Ribbon Block Macro is Displayed")]
        [NUnit.Framework.CategoryAttribute("Ribbon")]
        [NUnit.Framework.TestCaseAttribute("Macro", null)]
        public virtual void HomeRibbonBlockMacroIsDisplayed(string ribbon, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Ribbon"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Home Ribbon Block Macro is Displayed", null, @__tags);
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 57
testRunner.Given("a user opens SAM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
testRunner.When("the warning message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
testRunner.Then("the user can click on the OK button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
testRunner.And(string.Format("the ribbon \"{0}\" is displayed", ribbon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

