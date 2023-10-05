

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        char Sex { get; }
        void AddScores(float scores);
        void AddScores(string scores);
        void AddScores(double scores);
        void AddScores(int scores);
        void AddScores(char scores);
        Statistics GetStatistics();
    }
}
