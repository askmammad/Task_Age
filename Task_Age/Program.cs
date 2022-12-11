namespace Task_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            Console.WriteLine("Day of birth");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month of birth");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year of birth");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Day");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year");
            f = Convert.ToInt32(Console.ReadLine());
            if (b < e)
            {
                Console.WriteLine($"{f - c} yash");
            }
            else if (b == e && d > a)
            {
                Console.WriteLine($"{f - c} yash");
            }
            else
            {
                Console.WriteLine($"{f - c - 1} yash");
            }
        }
    }
}