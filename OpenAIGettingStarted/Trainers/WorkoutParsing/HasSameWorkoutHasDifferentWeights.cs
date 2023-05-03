namespace OpenAIGettingStarted.Trainers.WorkoutParsing
{
    [Trainer(typeof(WorkoutParsingTrainer))]
    public class HasSameWorkoutHasDifferentWeights : PromptExample
    {
        public override string Input => @"METCON:
                50 Thrusters @53lb
                100 Single-arm KB Swings @70lb
                50 Thrusters @70lb
                200 Macebell 360s @20lb
                50 Thrusters @53lb
                ";
        public override string Output => @"
                [{ 'reps': '20', 'exercise' : 'Thrusters', 'weight' : '53', 'units': 'pounds' },
                 { 'reps': '24', 'exercise' : 'Thrusters', 'weight' : '70' , 'units': 'pounds'},
                 { 'reps': '100', 'exercise' : 'Single-arm KB Swings', 'weight' : '70', 'units': 'pounds' },
                 { 'reps': '200', 'exercise' : 'Macebell 360s', 'weight' : '20', 'units': 'pounds' }]";
    }

    [Trainer(typeof(WorkoutParsingTrainer))]
    public class BuyInCountReinfocement: PromptExample
    {
        public override string Input => @"Buy-in:
    - 100 KB Swings @53lb

    5 Rounds:
    - 10 Macebell 360's into Uppercut @30lb
    - 20 KB Swings @53lb";
        public override string Output => @"
                [{ 'reps': '50', 'exercise' : 'Macebell 360\'s into Uppercut', 'weight' : '70', 'units': 'pounds' },
                 { 'reps': '200', 'exercise' : 'Macebell 360s', 'weight' : '20', 'units': 'pounds' }]";
    }
}
