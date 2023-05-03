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
                [{ 'reps': '20', 'exercise' : 'Deadlifts', 'weight' : '135', 'units': 'pounds' },
                 { 'reps': '24', 'exercise' : 'Deadlifts', 'weight' : '185', 'units': 'pounds' },
                 { 'reps': '100', 'exercise' : 'Single-arm KB Swings', 'weight' : '53', 'units': 'pounds' },
                 { 'reps': '10', 'exercise' : 'Turkish Getups', 'weight' : '53', 'units': 'pounds' }]                 
                ";
    }
}
