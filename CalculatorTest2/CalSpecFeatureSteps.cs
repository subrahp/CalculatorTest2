using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CalculatorTest2
{
    [Binding]
    public class CalSpecFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int x)
        {
            int a = x;
            Console.WriteLine("First number is" + a);
        }

        [Given(@"Also have entered (.*) into the calculator")]
        public void GivenAlsoHaveEnteredIntoTheCalculator(int y)
        {

            int b = y;
            Console.WriteLine("Second number is" + b);
        }


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Calculation");
        }

        [Then(@"the result of adding (.*) and (.*) should be (.*) on the screen")]
        public void ThenTheResultOfAddingAndShouldBeOnTheScreen(int x, int y, int result)
        {
            int a = x;
            int b = y;
            int E = x + y;
            Assert.AreEqual(E, result);
            Console.Out.WriteLine("Test Completed");
        }
    }
}

