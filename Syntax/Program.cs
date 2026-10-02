namespace Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Check(string label, object? actual, object? expected)
            {
                string a = actual?.ToString() ?? "null";
                string b = expected?.ToString() ?? "null";
                Console.WriteLine(a == b ? $"OK    {label} = {a}"
                                         : $"ERROR {label} = {a}, expected {b}");
            }

            double Average(int[] numbers)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                double avg = sum/numbers.Length;

                return avg;
            }

            string Cell(string text, int width)
            {
                if (text.Length > width)
                {
                    return text.Substring(0, width);
                }

                return text.PadRight(width);
            }

            string Initials(string fullName)
            {
                string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string result = "";

                foreach (string part in parts)
                {
                    result += (part[0] + ".").ToUpper();
                }

                return result;
            }
            int CountVowels(string text)
            {
                char[] vowels = { 'q', 'e', 'y', 'u', 'i', 'o', 'a', 'x', 'v'};

                int vowelsSum = 0;
                foreach (char c in text)
                {
                    if (vowels.Contains(c))
                    {
                        vowelsSum++;
                    }
                }
                return vowelsSum;
            }

            string Reverse(string text)
            {
                char[] chars = text.ToCharArray();
                Array.Reverse(chars);

                string reversed = new string(chars);

                return reversed;
            }
            string Longest(string[] texts)
            {
                string result = "";
                foreach (string text in texts)
                {
                    if (text.Length > result.Length)
                    {
                        result = text;
                    }
                }

                return result;
            }
            int[] Evens(int[] numbers)
            {
                List<int> evens = new List<int>();

                foreach (int n in numbers)
                {
                    if (n%2 == 0)
                    {
                        evens.Add(n);
                    }
                }
                return evens.ToArray();
            }

            int[] WithoutEdges(int[] numbers)
            {

                return numbers[1..^1];
            }

            int? FirstNegative(int[] numbers)
            {
                foreach (int n in numbers)
                {
                    if (n < 0)
                    {
                        return n;
                    }
                }
                return null;
            }

            int SumNumbers(string text)
            {
                int result = 0;
                foreach (string part in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                {
                    if (int.TryParse(part, out int number))
                    {
                        result += number;
                    }
                }

                return result;
            }

            Check("Average", Average([1, 2, 3, 4]), 2.5);
            Check("Average", Average([10, 20, 30]), 20);
            Check("Average", Math.Round(Average([-1, 1, 2]), 2), 0.67);
            Check("Cell", Cell("Ala", 6) + "|", "Ala   |");
            Check("Cell", Cell("Mickey Mouse", 6), "Mickey");
            Check("Initials", Initials("Mickey Mouse"), "M.M.");
            Check("Initials", Initials("Pluto"), "P.");
            Check("Initials", Initials("aa b c d"), "A.B.C.D.");
            Check("Initials", Initials("a   5   .,p"), "A.5...");
            Check("CountVowels", CountVowels("Cinderella"), 4);
            Check("CountVowels", CountVowels("Maui"), 3);
            Check("Reverse", Reverse("Olaf"), "falO");
            Check("Reverse", Reverse("kajak"), "kajak");
            Check("Longest", Longest(["Elsa", "Anna", "Olaf"]), "Elsa");
            Check("Longest", Longest(["Timon", "Pumbaa", "Simba"]), "Pumbaa");
            Check("Evens", string.Join(", ", Evens([1, 2, 3, 4, 6])), "2, 4, 6");
            Check("Evens", string.Join(", ", Evens([-4, -3, 0, 7])), "-4, 0");
            Check("Evens", Evens([1, 3]).Length, 0);
            Check("WithoutEdges", string.Join(", ", WithoutEdges([1, 2, 3, 4])), "2, 3");
            Check("FirstNegative", FirstNegative([3, -2, 8, -5]), -2);
            Check("FirstNegative", FirstNegative([3, 8]), null);
            Check("SumNumbers", SumNumbers("12 kot 8"), 20);
            Check("SumNumbers", SumNumbers("-3 4"), 1);
            Check("SumNumbers", SumNumbers("bez liczb"), 0);
            Check("SumNumbers", SumNumbers("kot 45a -9  8,9"), -9);
        }
    }
}
