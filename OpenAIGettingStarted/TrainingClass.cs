using OpenAI_API;
using OpenAIGettingStarted;

public static class TrainingClass
{
    public static async Task<string> TrainAndAnswer(this OpenAIAPI api, PromptTrainer trainer, string question)
    {
        var chat = api.Chat.CreateConversation();
        chat.AppendSystemMessage(trainer.SystemInstructions);
        foreach (var example in trainer.Training)
        {
            chat.AppendUserInput(example.Input);
            chat.AppendExampleChatbotOutput(example.ExpectedOutput);
        }
        chat.AppendUserInput(question);

        return await chat.GetResponseFromChatbotAsync();
    }
}