// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int QuickFindOverlap(string[] split1)
{
    for (int i = int.Parse(split1[0]); i <= int.Parse(split1[1]); i++)
    {
        for (int j = int.Parse(split1[2]); j <= int.Parse(split1[3]); j++)
        {
            if (i == j)
            {
                return 1;
            }
        }
    }

    return 0;
}

string[] ReadTextFileFromPath(string Path)
{
    string[] output = File.ReadAllLines(Path);
    return output;
}

int ParseIntoAnwser(string[] input)
{
    int count = 0;
    foreach (var line in input)
    {
        char[] sep = { '-', ',' };
        string[] split1 = line.Split(sep);

        //if (int.Parse(split1[0]) >= int.Parse(split1[2]) && int.Parse(split1[1]) <= int.Parse(split1[3]))
        //{
        //    count++;
        //}
        //else if (int.Parse(split1[2]) >= int.Parse(split1[0]) && int.Parse(split1[3]) <= int.Parse(split1[1]))
        //{
        //    count++;
        //}

        count += QuickFindOverlap(split1);

    }

    return count;
}


string[] InputText = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day4/Day4Input.txt");
string[] InputTest = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day4/Day4Test.txt");
Console.WriteLine(ParseIntoAnwser(InputText));