namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        MyCalci.Calculator obj= new MyCalci.Calculator();
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 
            obj.a = number;
            //throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            obj.b = number;
            //throw new PendingStepException();
        }
        int AddAns;
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            AddAns = obj.Add();
            //throw new PendingStepException();
        }

        [Then("the Add result should be (.*)")]
        public void ThenTheAddResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            AddAns.Should().Be(result);    
            //throw new PendingStepException();
        }


        int SubAns;
        [When("the two numbers are Subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            //TODO: implement act (action) logic
            SubAns = obj.Sub();
            //throw new PendingStepException();
        }

        [Then("the Sub result should be (.*)")]
        public void ThenTheSubResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            SubAns.Should().Be(result);
            //throw new PendingStepException();
        }

        int MulAns;
        [When("the two numbers are Multiply")]
        public void WhenTheTwoNumbersAreMultiply()
        {
            //TODO: implement act (action) logic
            MulAns = obj.Mul();
            //throw new PendingStepException();
        }

        [Then("the Mul result should be (.*)")]
        public void ThenTheMulResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            MulAns.Should().Be(result);
            //throw new PendingStepException();
        }


        int DivAns;
        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            //TODO: implement act (action) logic
            DivAns = obj.Div();
            //throw new PendingStepException();
        }

        [Then("the Div result should be (.*)")]
        public void ThenTheDivResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            result.Should().Be(DivAns);
            //throw new PendingStepException();
        }
    }
}