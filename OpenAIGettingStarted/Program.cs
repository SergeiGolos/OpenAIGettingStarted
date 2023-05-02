using Autofac;
using OpenAI_API;
using OpenAIGettingStarted;

var builder = new ContainerBuilder();
builder.RegisterModule<OpenAIModule>();

var container = builder.Build();
var api = container.Resolve<OpenAIAPI>();
var training = new WorkoutParsingTrainer();

var chat = api.Chat.CreateConversation();
chat.AppendSystemMessage(training.SystemInstructions);
foreach (var example in training.Training)
{
    chat.AppendUserInput(example.Input);
    chat.AppendExampleChatbotOutput(example.ExpectedOutput);
}
chat.AppendUserInput(@"5 Rounds:
- 10 Macebell 360's into Uppercut @30lb
- 20 KB Swings @80lb

Buyout: 
- 100 burpees.
");

string response = await chat.GetResponseFromChatbotAsync();
Console.WriteLine(response); // "Yes"
Console.ReadKey();
