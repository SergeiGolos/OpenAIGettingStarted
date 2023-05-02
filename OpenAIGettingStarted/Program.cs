 using Autofac;
using OpenAI_API;
using OpenAIGettingStarted;
using OpenAIGettingStarted.Trainers;

var builder = new ContainerBuilder();
builder.RegisterModule<OpenAIModule>();
var container = builder.Build();

var response = await container.Resolve<OpenAIAPI>()
    .TrainAndAnswer(new WorkoutParsingTrainer(),
    @"5 Rounds:
    - 10 Macebell 360's into Uppercut @30lb
    - 20 KB Swings @80lb

    Buyout: 
    - 100 burpees.
    ");

Console.WriteLine(response); // "Yes"
