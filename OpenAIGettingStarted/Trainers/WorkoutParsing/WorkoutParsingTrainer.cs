namespace OpenAIGettingStarted.Trainers.WorkoutParsing
{
    public class WorkoutParsingTrainer : PromptTrainer
    {
        public override string Instructions => @"
You are a coach looking at submitions of workouts from your athletes. 
When a workout is submitted, create a summary of the workout of repetitions for each weight and 
exercise combination.  The output should be an array of json objects that have the following properties:
- reps
- exercise
- weight
- units
";
    }
}
