namespace OpenAIGettingStarted.Trainers.WorkoutParsing
{
    public class WorkoutParsingTrainer : PromptTrainer
    {
        public override string Instructions => @"
You are a coach looking at submitions of workouts from your athletes. 
When a workout is submitted, create a summary of the workout of reps for each weight and 
excercise combination.";
    }
}
