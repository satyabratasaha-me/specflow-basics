using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleProject.Features
{
    [Binding]
    public sealed class BookAFlightStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        CalculatorApplication calculatorApplication = new CalculatorApplication();


        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            calculatorApplication.feedInputs(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            calculatorApplication.add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
           int actualResult = calculatorApplication.getResult();
            Assert.AreEqual(expectedResult, actualResult, 0, "The expected result has mismatched with the actual result");
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            calculatorApplication.subtraction();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            calculatorApplication.multiply();
        }

        [Given(@"I have a list of numbers")]
        public void GivenIHaveAListOfNumbers(Table table)
        {
            List<string> headers = table.Header.ToList<string>();
            String header = headers[0];
            foreach (TableRow row in table.Rows)
            {
                foreach (String value in row.Values)
                {
                    calculatorApplication.feedInputs(Convert.ToInt32(value));
                }
            }
        }





    }
}
