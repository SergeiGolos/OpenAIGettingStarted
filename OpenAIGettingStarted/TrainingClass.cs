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
        chat.AppendSystemMessage(trainer.Instructions);
        foreach (var example in examples)
        {
            chat.AppendUserInput(example.Input);
            chat.AppendExampleChatbotOutput(example.Output);
        }
        chat.AppendUserInput(question);

        return await chat.GetResponseFromChatbotAsync();
    }
}