﻿using System.Diagnostics;
using SAM.WinFormObjects;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SAM.Steps
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        private readonly Calculator _calculator;
        private static Process _driver;

        
        [Given(@"I navigated to Standard Calculator")]
        public void GivenINavigatedToStandard()
        {
            _calculator.NavigateToStandard();
        }

        [Given(@"I have entered (.*) into calculator")]
        public void GivenIHaveEnteredIntoCalculator(string p0)
        {
            _calculator.EnterNumber(p0);
        }

        [Given(@"I press (.*)")]
        public void GivenIPress(string p0)
        {
            _calculator.EnterSign(p0);
        }

        [When(@"I press (.*)")]
        public void WhenIPressEquals(string p0)
        {
            _calculator.EnterSign(p0);
        }

        [Then(@"Calculator title is (.*)")]
        public void ThenBrowserTitleIs(string p0)
        {
            _calculator.GetTitle().Should().Be(p0);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            _calculator.GetResult().Should().Be(p0);
        }

        
    }
}

