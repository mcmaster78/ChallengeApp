using ChallengeApp;

var employee = new Employee("Marcin", "Stefański");
float floatValue = 1.78685F;
double doubleValue = 3.9872828355;
decimal decimalValue = 6.676766567M;
byte byteValue = 100;

employee.AddScores(floatValue);
employee.AddScores(doubleValue);
employee.AddScores(decimalValue);
employee.AddScores(byteValue);

var statistics = employee.GetStatisticsWithForEach();
Console.WriteLine("Wyniki dla pętli foreach:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

statistics = employee.GetStatisticsWithFor();
Console.WriteLine("Wyniki dla pętli for:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

statistics = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Wyniki dla pętli do while:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

statistics = employee.GetStatisticsWithWhile();
Console.WriteLine("Wyniki dla pętli while:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

