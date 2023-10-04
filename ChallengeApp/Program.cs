using ChallengeApp;

var employee = new Employee("Marcin", "Stefański", 'M');

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
    try
    {
        employee.AddScores(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Wystąpił wyjatek: { e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);
Console.WriteLine("");
