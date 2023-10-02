namespace CallengeApp.Tests
{
    using ChallengeApp;

    public class Tests
    {


        [Test]
        public void TestGetStatisticsMax()
        { 
            var employee = new Employee("Miœ", "Korargol");
            employee.AddScores(-2);
            employee.AddScores(-1);
            employee.AddScores(5);
            employee.AddScores(0);
            var result = employee.GetStatistics();
            
            Assert.AreEqual(5, result.Max);
        }
        [Test]
        public void TestGetStatisticsMin()
        {
            var employee = new Employee("Miœ", "Korargol");
            employee.AddScores(3);
            employee.AddScores(4);
            employee.AddScores(-5);
            employee.AddScores(0);
            var result = employee.GetStatistics();
            
            Assert.AreEqual(-5, result.Min);
        }
        [Test]
        public void TestGetStatisticsAverage()
        {
            var employee = new Employee("Miœ", "Korargol");
            employee.AddScores(3);
            employee.AddScores(5);
            employee.AddScores(4);
            employee.AddScores(0);
            var result = employee.GetStatistics();
            
            Assert.AreEqual(3, result.Average);
        }
    }
}
