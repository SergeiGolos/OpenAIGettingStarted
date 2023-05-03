namespace OpenAIGettingStarted.Trainers.WorkoutParsing
{
    [Trainer(typeof(WorkoutParsingTrainer))]
    public class CombineBodyWeightExample : PromptExample
    {
        public override string Input => @"Buy-in:
    - 100 burpees

    5 Rounds:
    - 10 Macebell 360's into Uppercut @30lb
    - 20 KB Swings @80lb
    - 30 burpees

    Buyout: 
    - 100 burpees";

        public override string Output => @"[{ 'reps': '350', 'exercise' : 'Burpees', 'weight' : 'Bodyweight', 'units': '' },
                 { 'reps': '50', 'exercise' : 'Macebell 360s into Uppercut', 'weight' : '30', 'units': 'pounds' },
                 { 'reps': '100', 'exercise' : 'KB Swings', 'weight' : '80', 'units': 'pounds' }]";
    }
}
