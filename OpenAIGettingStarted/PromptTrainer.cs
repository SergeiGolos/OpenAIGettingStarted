namespace OpenAIGettingStarted
{
    public abstract class PromptTrainer : IPromptTrainer
    {
        public abstract string Instructions { get; }        
    }
}
