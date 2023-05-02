using Autofac;
using Microsoft.Extensions.Configuration;
using OpenAI_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OpenAIGettingStarted
{    
    internal class OpenAIModule : Module
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
