
namespace ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public override event ScoresAddedDelegate ScoresAdded;

        private List<float> scores = new List<float>();

        public EmployeeInMemory(string name, string surname, char sex) : base(name, surname, sex)
        {
        }

         public override void AddScores(float scores)
        {
            if (scores >= 0 && scores <= 100)
            {
                this.scores.Add(scores);

                if (ScoresAdded != null)
                {
                    ScoresAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Podana liczba jest poza dostępnym zakresem (0-100)");

            }
        }
        public override void AddScores(string scores)
        {
            if (float.TryParse(scores, out float result))
            {
                this.AddScores(result);
            }
            else if (char.TryParse(scores, out char charResult))
            {
                this.AddScores(charResult);
            }
            else
            {
                throw new Exception("Podane dane nie są liczbą lub literą");

            }

        }

        public override void AddScores(double scores)
        {
            this.AddScores((float)scores);
        }

        public override void AddScores(int scores)
        {
            this.AddScores((float)scores);
        }

        public override void AddScores(char scores)
        {
            switch (scores)
            {
                case 'A':
                case 'a':
                    this.AddScores(100);
                    break;
                case 'B':
                case 'b':
                    this.AddScores(80);
                    break;
                case 'C':
                case 'c':
                    this.AddScores(60);
                    break;
                case 'D':
                case 'd':
                    this.AddScores(40);
                    break;
                case 'E':
                case 'e':
                    this.AddScores(20);
                    break;
                default:
                    throw new Exception("Podano złą literę");

            }

        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var score in scores)
            {
                statistics.AddScores(score);
            }
            return statistics;

        }
    }
}
