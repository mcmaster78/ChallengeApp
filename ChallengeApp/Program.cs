using ChallengeApp;
using System.Text;

var employee = new EmployeeInFile("Marcin", "Stefański", 'M');

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
//Console.WriteLine("Można używać znaków od 1 do 6 bez znaku, lub ze znakiem '+' / '-'. Wyjscie=q");
Console.WriteLine("");
Console.WriteLine("Podaj ocenę pracownika:");

while (true)
{
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
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);
Console.WriteLine("");
