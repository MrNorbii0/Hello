namespace HelloFull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));   // 5

            int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
}
