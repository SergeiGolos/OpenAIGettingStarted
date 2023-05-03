using Autofac;
using Microsoft.Extensions.Configuration;
using OpenAI_API;

namespace OpenAIGettingStarted
{
    public class OpenAIModule : Module
    {        
        protected override void Load(ContainerBuilder builder)
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets(typeof(Program).Assembly)
                .Build();

            var api = new OpenAIAPI(configuration.GetValue<string>("OpenAI:ApiKey"));

            builder.RegisterInstance(api);
        }
    }
}
