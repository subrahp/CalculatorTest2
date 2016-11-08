using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CalculatorTest2
{
    [Binding]
    public class CalSpecFeature2Steps
    {
        [Given(@"We have entered (.*) into the calculator")]
        public void GivenWeHaveEnteredIntoTheCalculator(int x)
        {
            int a = x;
            Console.WriteLine("First number is" + a);
        }
        
        [Given(@"We also have entered (.*) into the calculator")]
        public void GivenWeAlsoHaveEnteredIntoTheCalculator(int y)
        {
            int b = y;
            Console.WriteLine("Second number is" + b);
        }
        
        [When(@"We perform add operation")]
        public void WhenWePerformAddOperation()
        {
            Console.WriteLine("Calculation");
        }
        
        [Then(@"Output of adding (.*) and (.*) should be (.*) on the screen")]
        public void ThenOutputOfAddingAndShouldBeOnTheScreen(int x, int y, int result)
        {
            int a = x;
            int b = y;
            int E = x + y;
            Assert.AreEqual(E, result);
            Console.Out.WriteLine("Test Completed");
        }
    }
}
