// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

string[] ReadTextFileFromPath(string Path)
{
    string[] output = File.ReadAllLines(Path);
    return output;
}

int ParseIntoAnwser(string[] input)
{
    int output = 0;
    List<char> letterList = new();
    for (int i = 0; i < input.Length; i++)
    {
        string line = input[i];
        //char[] lineArray = line.ToCharArray();
        //char[] firstCompartment = lineArray.Take(lineArray.Length / 2).ToArray();
        //char[] secondCompartment = lineArray.Skip(lineArray.Length / 2).ToArray();

        //letterList.Add(FindFirstIntanceOfDuplicate(firstCompartment, secondCompartment));

        if ((i + 1) % 3 == 0)
        {
            letterList.Add(FindFirstIntanceOfDuplicateIn3Arrays(input[i-2].ToCharArray(), input[i - 1].ToCharArray(), input[i].ToCharArray()));
        }
    }

    foreach (char letter in letterList)
    {
        int number = letter;

        if (Char.IsLower(letter))
        {
            number -= 96;
        }
        else
        {
            number -= 38;
        }

        output += number;
    }

    return output;
}


string[] InputText = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day3/Day3Input.txt");
string[] InputTest = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day3/Day3Test.txt");
Console.WriteLine(ParseIntoAnwser(InputText));

char FindFirstIntanceOfDuplicate(char[] firstCompartment, char[] secondCompartment)
{
    for (int i = 0; i < firstCompartment.Length; i++)
    {
        for (int j = 0; j < secondCompartment.Length; j++)
        {
            if (firstCompartment[i] == secondCompartment[j])
            {
                return firstCompartment[i];
            }
        }
    }
    return '.';
}

char FindFirstIntanceOfDuplicateIn3Arrays(char[] group1, char[] group2, char[] group3)
{
    for (int i = 0; i < group1.Length; i++)
    {
        for (int j = 0; j < group2.Length; j++)
        {
            for (int k = 0; k < group3.Length; k++)
            {
                if (group1[i] == group2[j] && group1[i] == group3[k] && group2[j] == group3[k])
                {
                    return group1[i];
                }

            }
        }
    }
    return '.';
}