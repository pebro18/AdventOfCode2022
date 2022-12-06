// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] ReadTextFileFromPath(string Path)
{
    string[] output = File.ReadAllLines(Path);
    return output;
}

string ParseIntoAnwser(string[] input)
{
    return "";
}


string[] InputText = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day5/Day5Input.txt");
string[] InputTest = ReadTextFileFromPath("C:/Users/pebro/source/repos/AdventOfCode2022/Day5/Day5Test.txt");
Console.WriteLine(ParseIntoAnwser(InputTest));