//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ChallengeApp
{
     public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public float Count { get; private set; }
        public float Average
        { 
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageLetter 
        { 
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
        }
        public void AddScores(float score)
        {
            this.Count++;
            this.Sum += score;
            this.Min = Math.Min(score, this.Min);
            this.Max = Math.Max(score, this.Max);
        }
    }
}

