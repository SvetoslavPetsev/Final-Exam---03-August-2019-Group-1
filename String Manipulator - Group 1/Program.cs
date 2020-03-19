using System;

namespace String_Manipulator___Group_1
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] cmdArgs = input.Split();
                string cmd = cmdArgs[0];
                if (cmd == "Translate")
                {
                    char symbol = char.Parse(cmdArgs[1]);
                    char replacment = char.Parse(cmdArgs[2]);
                    text = text.Replace(symbol, replacment);
                    Console.WriteLine(text);
                }
                else if (cmd == "Includes")
                {
                    string substr = cmdArgs[1];
                    Console.WriteLine(text.Contains(substr));
                }
                else if (cmd == "Start")
                {
                    string substr = cmdArgs[1];
                    if (substr.Length <= text.Length)
                    {
                        string startSubstr = text.Substring(0, substr.Length);
                        Console.WriteLine(substr == startSubstr);
                    }
                }
                else if (cmd == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (cmd == "FindIndex")
                {
                    char symbol = char.Parse(cmdArgs[1]);
                    int index = text.LastIndexOf(symbol);
                    Console.WriteLine(index);
                }
                else if (cmd == "Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);

                    if (startIndex >= 0 && startIndex + count <= text.Length)
                    {
                        string substr = text.Substring(startIndex, count);
                        text = text.Replace(substr, string.Empty);
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}
