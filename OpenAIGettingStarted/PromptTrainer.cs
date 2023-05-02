namespace OpenAIGettingStarted
{
    public class PromptTrainer
    {
        public PromptTrainer(string systemInstructions) => SystemInstructions = systemInstructions;

        public string SystemInstructions { get; set; }
        
        public List<PromptExample> Training { get; set; } = new List<PromptExample>();

        public PromptTrainer Example(PromptExample example)
        {
            Training.Add(example);
            return this;
        }
    }
}
