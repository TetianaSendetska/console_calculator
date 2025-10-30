using Calculator;
using Calculator.Modes;

string instructionPath = "instruction.txt";
List<IMode> modes = new()
{
    new SimpleMode(),
    new AdvancedMode()
};

Console.WriteLine(FileHandler.ReadFromFile(instructionPath));


while (true)
{
    Console.WriteLine("Choose a mode:");
    for (int i = 0; i < modes.Count; i++)
        Console.WriteLine($"\t{i + 1} - {modes[i].Name}");

    Console.WriteLine("\t0 - Exit");

    string? option = Console.ReadLine();

    if (option == "0")
        break;

    if (int.TryParse(option, out int index) && index >= 1 && index <= modes.Count)
    {
        modes[index - 1].Start();
    }
    else
    {
        Console.WriteLine("Invalid option, try again.");
    }

}