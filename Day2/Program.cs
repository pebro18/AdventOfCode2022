// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] ReadTextFileFromPath(string Path)
{
    string[] output = File.ReadAllLines(Path);
    return output;
}

int ParseStringIntoPuzzelAnwser(string[] input)
{
    int output = 0;
    foreach (string line in input)
    {
        int score = 0;
        List<int> play = new();

        char[] lineArray = line.ToCharArray();
        for (int i = 0; i < lineArray.Length; i++)
        {
            if (i == 2)
                switch (lineArray[2])
                {
                    case 'X':
                        if (play[0] == 1)
                        {
                            play.Add(3);
                            score += 3;
                        }
                        else
                        {
                            play.Add(play[0] - 1);
                            score += play[0] - 1;
                        }
                        break;
                    case 'Y':
                        play.Add(play[0]);
                        score += play[0];
                        break;
                    case 'Z':
                        if (play[0] == 3)
                        {
                            play.Add(1);
                            score++;
                        }
                        else
                        {
                            play.Add(play[0] + 1);
                            score += play[0] + 1;
                        }
                        break;
                }
            else
                switch (lineArray[i])
                {
                    case 'A':
                    case 'X':
                        play.Add(1);
                        if (i == 2)
                            score += 1;
                        break;
                    case 'B':
                    case 'Y':
                        play.Add(2);
                        if (i == 2)
                            score += 2;
                        break;
                    case 'C':
                    case 'Z':
                        play.Add(3);
                        if (i == 2)
                            score += 3;
                        break;
                }
        }

        switch (play[0])
        {
            case 1 when play[1] == 2:
                score += 6;
                break;
            case 2 when play[1] == 3:
                score += 6;
                break;
            case 3 when play[1] == 1:
                score += 6;
                break;
            default:
                if (play[0] == play[1])
                {
                    score += 3;
                }
                break;
        }

        output += score;
    }

    return output;
}

string[] InputText = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day2/Day2Input.txt");
int output = ParseStringIntoPuzzelAnwser(InputText);
Console.WriteLine(output);