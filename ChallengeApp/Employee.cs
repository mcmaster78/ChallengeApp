namespace ChallengeApp
{
    public class Employee
    {
        private List<float> scores = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }
     
        //public int Age { get; private set; }
        
        public void AddScores(float scores)
        {
            if (scores >= 0 && scores <= 100)
            {
                this.scores.Add(scores);
            }
            else
            {
                Console.WriteLine("Podana liczba jest poza dostępnym zakresem (0-100)");
            }
        }
        public void AddScores(string scores)
        {
            if (float.TryParse(scores, out float result))
            {
                this.AddScores(result);
            }
            else
            {
                Console.WriteLine("Podane dane nie reprezentują liczby float");
            }
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

        //public int GetSumScores()
        //{
        //    return this.scores.Sum();
        //}
        public Statistics GetStatisticsWithForEach()
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
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            for (var i=0; i<scores.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.scores[i]);
                statistics.Min = Math.Min(statistics.Min, this.scores[i]);
                statistics.Average += this.scores[i];
            }
            statistics.Average = statistics.Average / this.scores.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            int index = 0;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.scores[index]);
                statistics.Min = Math.Min(statistics.Min, this.scores[index]);
                statistics.Average += this.scores[index];
                index++;
            } while (index < this.scores.Count);
            statistics.Average = statistics.Average / this.scores.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            int index = 0;
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            while (index < this.scores.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.scores[index]);
                statistics.Min = Math.Min(statistics.Min, this.scores[index]);
                statistics.Average += this.scores[index];
                index++;
            } 
            statistics.Average = statistics.Average / this.scores.Count;
            return statistics;
        }



    }
}

