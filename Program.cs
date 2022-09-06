using System;
 
string[] array =
{
    "I",
    "see",
    "the",
    "sea",
    "1250",
    "5000"
};
 
var result = new string[array.Length];
var newSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[newSize] = value;
        newSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, newSize));
