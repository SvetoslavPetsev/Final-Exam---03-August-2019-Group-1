using System;
using System.Text.RegularExpressions;


namespace Message_Decrypter
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string text = Console.ReadLine();

                Regex pattern = new Regex(@"^([\$\%])(?<tag>[A-Z][a-z]{2,})\1\:\s\[(?<one>[0-9]+)\]\|\[(?<two>[0-9]+)\]\|\[(?<three>[0-9]+)\]\|$");

                Match matchText = pattern.Match(text);

                if (matchText.Success)
                {
                    string tag = matchText.Groups["tag"].Value;
                    int symbolOne = int.Parse(matchText.Groups["one"].Value);
                    int symbolTwo = int.Parse(matchText.Groups["two"].Value);
                    int symbolThree = int.Parse(matchText.Groups["three"].Value);
                    string decription = $"{(char)symbolOne}{(char)symbolTwo}{(char)symbolThree}";

                    Console.WriteLine($"{tag}: {decription}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
