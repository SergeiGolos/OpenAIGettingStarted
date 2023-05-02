using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAIGettingStarted
{
    public class WorkoutParsingTrainer : PromptTrainer
    {
        private const string systemPrompt = @"
You are a coach looking at submitions of workouts from your athletes. 
When a workout is submitted, create a summary of the workout of reps for each weight and 
excercise combination.";

        public WorkoutParsingTrainer() : base(systemPrompt)
        {
            Example(new PromptExample(@"Strength:
                10 deadlifts @135lb
                10 deadlifts @135lb
                8 deadlifts @185lb
                8 deadlifts @185lb
                8 deadlifts @185lb

                METCON:
                100 Single-arm KB Swings @53lb
                10 Turkish Getups @53lb
                ")
            .ResultsIn(@"
                Summary
                - 20 deadlifts @135lb
                - 24 deadlifts @185lb
                - 100 Single-arm KB Swings @53lb
                - 10 Turkish Getups @53lb
                "));

            Example(new PromptExample(@"METCON:
                50 Thrusters @53lb
                100 Single-arm KB Swings @70lb
                50 Thrusters @70lb
                200 Macebell 360s @20lb
                50 Thrusters @53lb
                ")
            .ResultsIn(@"Summary:
                - 100 Thrusters @53lb
                - 50 Thrusters @70lb
                - 100 Single-arm KB Swings @70lb
                - 200 Macebell 360s @20lb
                "));
        }
    }
}
