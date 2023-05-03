using Autofac;
using OpenAI_API;
using OpenAIGettingStarted;
using OpenAIGettingStarted.Trainers.WorkoutParsing;

var builder = new ContainerBuilder();
builder.RegisterModule<OpenAIModule>();
builder.RegisterModule<TrainersModule>();
var container = builder.Build();

var api = container.Resolve<OpenAIAPI>();

var trainer = container.Resolve<IPromptTrainer>();
var examples = container.ResolveKeyed<IEnumerable<PromptExample>>(trainer.GetType().Name);

var response = await api.TrainAndAnswer(trainer, examples,
    @"5 Rounds:
    - 10 Macebell 360's into Uppercut @30lb
    - 20 KB Swings @80lb

    Buyout: 
    - 100 burpees.
    ");

Console.WriteLine(response); // "Yes"
