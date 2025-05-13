// This class randomly selects questions to
// ask the user for each journal entry.

class Picker
    {
        static Random _rng = new Random();
        static List<string> _questions = [
            "Did you meet anyone new today?",
            "What has been the most exciting part of today?",
            "What are you most proud of for today?",
            "What was the most interesting interaction you had today?",
            "If you could do one thing over again, what would it be?",
            "What surprised you the most today?",
            "What did you learn today, either about yourself or the world?",
            "How did you take care of yourself today?",
            "Was there a moment you felt truly at peace?",
            "Did you face any challenges or obstacles today? How did you handle them?",
            "Who made a positive impact on your day?",
            "What is one thing you are grateful for today?",
            "How did you express kindness today, either to yourself or to someone else?",
            "What did you avoid doing today, and why?",
            "Was there a moment you wish you had handled differently?",
            "What made you smile or laugh today?",
            "What is one thing you would like to remember about today?",
            "Did anything today push you outside your comfort zone?"
        ];

        public static string GetRandom()
        {
            int index = _rng.Next(_questions.Count);
            return _questions[index];
        }
    }