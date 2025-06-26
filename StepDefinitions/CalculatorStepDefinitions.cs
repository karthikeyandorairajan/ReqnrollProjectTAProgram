using NUnit.Framework;
using Reqnroll.CommonModels;

namespace ReqnrollProjectTAProgram.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public Calculator calculator = new Calculator();
        public int result;

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            calculator.FirstNumber = firstNumber;

        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            calculator.SecondNumber = secondNumber;
        }

        //[When("the two numbers are added")]
        //public void WhenTheTwoNumbersAreAdded()
        //{
        //    result = calculator.Addition();
        //}

        //[When("the two numbers are subtracted")]
        //public void WhenTheTwoNumbersAreSubtracted()
        //{
        //    result = calculator.subtraction();
        //}

        //[When("the two numbers are multiplied")]
        //public void WhenTheTwoNumbersAreMultiplied()
        //{

        //    result = calculator.Multiplication();
        //}

        //[When("the two numbers are divided")]
        //public void WhenTheTwoNumbersAreDivided()
        //{
        //    result = calculator.Division();
        //}




        [When("the two numbers are (.*)")]

        public void WhenTheTwoNumbersAre(string operation)
        {
            switch (operation.ToLower()) // added
            {
                case "added":
                    result = calculator.Addition();
                    break;
                case "subtracted":
                    result = calculator.subtraction();
                    break;
                case "multiplied":
                    result = calculator.Multiplication();
                    break;
                case "divided":
                    result = calculator.Division();
                    break;
                default:
                    throw new ArgumentException($"Unknown operation: {operation}");

            }


        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.That(this.result, Is.EqualTo(expectedResult), $"Expected {expectedResult} but got {result}");


        }
    }
}
