namespace OpenAIGettingStarted
{
    public class PromptExample
    {
        public PromptExample(string input) => Input = input;
        public string Input { get; private set; }
        public string ExpectedOutput { get; private set; } = string.Empty;

        public PromptExample ResultsIn(string output)
        {
            this.ExpectedOutput = output;
            return this;
        }
    }
}
