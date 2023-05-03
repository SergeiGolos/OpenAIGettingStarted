using OpenAI_API;
using OpenAIGettingStarted;

public static class TrainingClass
{
    public static async Task<string> TrainAndAnswer(this OpenAIAPI api,
        IPromptTrainer trainer, 
        IEnumerable<PromptExample> examples,
        string question)
    {
        var chat = api.Chat.CreateConversation();        
        Console.WriteLine($"Training Instructions: {trainer.GetType().Name}");
        chat.AppendSystemMessage(trainer.Instructions);
        foreach (var example in examples)
        {
            Console.WriteLine($"Training Examples: {example.GetType().Name}");
            chat.AppendUserInput(example.Input);
            chat.AppendExampleChatbotOutput(example.Output);
        }
        chat.AppendUserInput(question);

        return await chat.GetResponseFromChatbotAsync();
    }
}