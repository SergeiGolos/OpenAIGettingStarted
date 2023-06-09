﻿namespace OpenAIGettingStarted
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TrainerAttribute : Attribute
    {
        public TrainerAttribute(Type type)
        {
            Trainer = type;
        }

        public Type Trainer { get; }
    }
}
