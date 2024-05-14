using System.Text.RegularExpressions;

Console.WriteLine("Введите строку:");
string inputstring = Console.ReadLine();

string needstring = @"\b(\w+)\b(?<=\b\1\b.*\b\1\b)|\b(\w+)\b(?=.*\b\2\b)";

string resultstring = Regex.Replace(inputstring, needstring , @"<strong>$1$2</strong>");

Console.WriteLine(resultstring);