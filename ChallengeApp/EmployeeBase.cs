
namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = name;
            this.Sex = sex;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }

        public abstract void AddScores(float scores);

        public abstract void AddScores(string scores);

        public abstract void AddScores(double scores);

        public abstract void AddScores(int scores);

        public abstract void AddScores(char scores);

        public abstract Statistics GetStatistics();
    }
}
