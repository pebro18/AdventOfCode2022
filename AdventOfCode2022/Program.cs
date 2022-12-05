// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] ReadTextFileFromPath(string Path)
{
    string[] output = File.ReadAllLines(Path);
    return output;
}

int[] ParseStringIntoPuzzelArray(string[] input)
{
    List<int> output = new();

    int AmountCalories = 0;
    foreach (string line in input)
    {
        if (!string.IsNullOrEmpty(line))
        {
            AmountCalories += int.Parse(line);
        }
        else
        {
            output.Add(AmountCalories);
            AmountCalories = 0;
        }
    }

    return output.ToArray();

}


void FindTheCorrectElf(int[] input)
{
    int output = input.Max();
    Console.WriteLine(output);

    Array.Sort(input);
    Array.Reverse(input);

    Console.WriteLine(input[0] + input[1] + input[2]);
}

string[] InputText = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day1Input.txt");
int[] ParsedInput = ParseStringIntoPuzzelArray(InputText);
FindTheCorrectElf(ParsedInput);