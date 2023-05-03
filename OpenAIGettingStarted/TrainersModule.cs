using Autofac;

namespace OpenAIGettingStarted
{
    public class TrainersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                .Where(n => n.IsAssignableTo<IPromptTrainer>())
                .Where(n => !n.IsAbstract)
                .Where(n => !n.IsInterface)
                .As<IPromptTrainer>()
                .Named(n => n.Name, typeof(IPromptTrainer));                
            
            builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                .Where(n => n.IsAssignableTo(typeof(PromptExample)))
                .Where(n => !n.IsAbstract)
                .As<PromptExample>() 
                .Keyed<PromptExample>(n => ((TrainerAttribute)n.GetCustomAttributes(typeof(TrainerAttribute), false).First()).Trainer.Name ?? string.Empty);
        }
    }
}
