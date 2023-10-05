
namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> scores = new List<float>();

        //   public string Name => throw new NotImplementedException();

        //   public string Surname => throw new NotImplementedException();

        //   public char Sex => throw new NotImplementedException();

        //   public void AddScores(float scores)
        //   {
        //       throw new NotImplementedException();
        //   }

        //   public void AddScores(string scores)
        //   {
        //       throw new NotImplementedException();
        //   }

        //   public void AddScores(double scores)
        //   {
        //       throw new NotImplementedException();
        //   }

        //   public void AddScores(int scores)
        //   {
        //       throw new NotImplementedException();
        //   }

        //   public void AddScores(char scores)
        //   {
        //       throw new NotImplementedException();
        //   }

        //   public Statistics GetStatistics()
        //   {
        //       throw new NotImplementedException();
        //   }

        //}
        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = name;
            this.Sex = sex;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }

        public void AddScores(float scores)
        {
            if (scores >= 0 && scores <= 100)
            {
                this.scores.Add(scores);
            }
            else
            {
                throw new Exception("Podana liczba jest poza dostępnym zakresem (0-100)");
                //Console.WriteLine("Podana liczba jest poza dostępnym zakresem (0-100)");
            }
        }
        public void AddScores(string scores)
        {
            switch (scores)
            {
                case "6":
                    this.AddScores(100);
                    break;
                case "6-":
                case "-6":
                    this.AddScores(95);
                    break;
                case "5":
                    this.AddScores(80);
                    break;
                case "+5":
                case "5+":
                    this.AddScores(85);
                    break;
                case "-5":
                case "5-":
                    this.AddScores(75);
                    break;
                case "4":
                    this.AddScores(60);
                    break;
                case "+4":
                case "4+":
                    this.AddScores(65);
                    break;
                case "-4":
                case "4-":
                    this.AddScores(55);
                    break;
                case "3":
                    this.AddScores(40);
                    break;
                case "+3":
                case "3+":
                    this.AddScores(45);
                    break;
                case "-3":
                case "3-":
                    this.AddScores(35);
                    break;
                case "2":
                    this.AddScores(20);
                    break;
                case "+2":
                case "2+":
                    this.AddScores(25);
                    break;
                case "-2":
                case "2-":
                    this.AddScores(15);
                    break;
                case "1":
                    this.AddScores(0);
                    break;
                case "+1":
                case "1+":
                    this.AddScores(5);
                    break;
                case "-1":
                case "1-":
                    this.AddScores(0);
                    break;
                default:
                    throw new Exception("Podane dane są spoza dostępnego zakresu");
                    break;

            }
            //if (float.TryParse(scores, out float result))
            //{
            //    this.AddScores(result);
            //}
            //else if (char.TryParse(scores, out char charResult))
            //{
            //    this.AddScores(charResult);
            //}
            //else
            //{
            //    throw new Exception("Podane dane nie są liczbą lub literą");

            //}
        }
        public void AddScores(double scores)
        {
            this.AddScores((float)scores);
        }
        public void AddScores(decimal scores)
        {
            this.AddScores((float)scores);
        }
        public void AddScores(byte scores)
        {
            this.AddScores((float)scores);
        }
        public void AddScores(int scores)
        {
            this.AddScores((float)scores);
        }
        public void AddScores(char scores)
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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var score in scores)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average = statistics.Average / this.scores.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

    }
}
