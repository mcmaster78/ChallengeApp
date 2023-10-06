namespace CallengeApp.Tests
{
    using ChallengeApp;

    public class Tests
    {


        [Test]
        public void TestGetStatisticsMaxA()
        { 
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("A");
            var result = employee.GetStatistics();
            
            Assert.AreEqual(100, result.Max);
        }
        [Test]
        public void TestGetStatisticsMinA()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("A");
            var result = employee.GetStatistics();
            
            Assert.AreEqual(100, result.Min);
        }
        public void TestGetStatisticsMaxB()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("B");
            var result = employee.GetStatistics();

            Assert.AreEqual(80, result.Max);
        }
        [Test]
        public void TestGetStatisticsMinB()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("B");
            var result = employee.GetStatistics();

            Assert.AreEqual(80, result.Min);
        }
        public void TestGetStatisticsMaxC()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("C");
            var result = employee.GetStatistics();

            Assert.AreEqual(60, result.Max);
        }
        [Test]
        public void TestGetStatisticsMinC()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("C");
            var result = employee.GetStatistics();

            Assert.AreEqual(60, result.Min);
        }
        public void TestGetStatisticsMaxD()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("D");
            var result = employee.GetStatistics();

            Assert.AreEqual(40, result.Max);
        }
        [Test]
        public void TestGetStatisticsMinD()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("D");
            var result = employee.GetStatistics();

            Assert.AreEqual(40, result.Min);
        }
        public void TestGetStatisticsMaxE()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("E");
            var result = employee.GetStatistics();

            Assert.AreEqual(20, result.Max);
        }
        [Test]
        public void TestGetStatisticsMinE()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores("E");
            var result = employee.GetStatistics();

            Assert.AreEqual(20, result.Min);
        }

        [Test]
        public void TestGetStatisticsAverage()
        {
            var employee = new EmployeeInFile("Miœ", "Korargol", 'M');
            employee.AddScores(50);
            employee.AddScores(50);
            employee.AddScores(50);
            var result = employee.GetStatistics();
            
            Assert.AreEqual(50, result.Average);
        }
    }
}
