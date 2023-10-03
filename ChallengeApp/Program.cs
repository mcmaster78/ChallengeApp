using ChallengeApp;

var employee = new Employee("Marcin", "Stefański");
//float floatValue = 1.78685F;
//double doubleValue = 3.9872828355;
//decimal decimalValue = 6.676766567M;
//byte byteValue = 80;

//employee.AddScores(floatValue);
//employee.AddScores(doubleValue);
//employee.AddScores(decimalValue);
//employee.AddScores(byteValue);
//employee.AddScores('a');

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddScores(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);
Console.WriteLine("");
