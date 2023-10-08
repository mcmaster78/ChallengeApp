

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event ScoresAddedDelegate ScoresAdded;

        private const string fileName = "scores.txt";

        public EmployeeInFile(string name, string surname, char sex) : base(name, surname, sex)
        {
        }

        public override void AddScores(float scores)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(scores);
            }
            if (ScoresAdded != null)
            {
                ScoresAdded(this, new EventArgs());
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
        }
        public override Statistics GetStatistics()
        {
            var scoresFromFile = LoadScoresFromFile();
            var result = this.CalculateStatistics(scoresFromFile);
            return result;
        }
        private List<float> LoadScoresFromFile()
        {
            var scores = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        scores.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return scores;
        }
        private Statistics CalculateStatistics(List<float> scores)
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
