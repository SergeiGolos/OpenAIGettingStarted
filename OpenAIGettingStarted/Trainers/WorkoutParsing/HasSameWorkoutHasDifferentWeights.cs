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

        public override string Output => @"Summary:
                - 100 Thrusters @53lb
                - 50 Thrusters @70lb
                - 100 Single-arm KB Swings @70lb
                - 200 Macebell 360s @20lb";
    }
}
