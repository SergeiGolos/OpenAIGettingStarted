namespace OpenAIGettingStarted.Trainers.WorkoutParsing
{
    [Trainer(typeof(WorkoutParsingTrainer))]
    public class MultipleSetExample : PromptExample
    {
        public override string Input => @"Strength:
                10 deadlifts @135lb
                10 deadlifts @135lb
                8 deadlifts @185lb
                8 deadlifts @185lb
                8 deadlifts @185lb

                METCON:
                100 Single-arm KB Swings @53lb
                10 Turkish Getups @53lb
                ";

        public override string Output => @"
                Summary
                - 20 deadlifts @135lb
                - 24 deadlifts @185lb
                - 100 Single-arm KB Swings @53lb
                - 10 Turkish Getups @53lb
                ";
    }
}
