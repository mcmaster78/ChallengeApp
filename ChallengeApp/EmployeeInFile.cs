

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
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
            var result = new Statistics();
            result.Average = 0;
            result.Max = float.MinValue;
            result.Min = float.MaxValue;
            foreach (var score in scores)
            {
                result.Max = Math.Max(result.Max, score);
                result.Min = Math.Min(result.Min, score);
                result.Average += score;
            }
            result.Average = result.Average / scores.Count;

            switch (result.Average)
            {
                case var average when average >= 80:
                    result.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    result.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    result.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    result.AverageLetter = 'D';
                    break;
                default:
                    result.AverageLetter = 'E';
                    break;
            }
            return result;
        }
     }
}
