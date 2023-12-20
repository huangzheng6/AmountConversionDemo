namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal value = 100000;
            Console.WriteLine(value.GetTenThousandsYuan());

            value = 126500;
            Console.WriteLine(value.GetTenThousandsYuan());

            value = 126570;
            Console.WriteLine(value.GetTenThousandsYuan());

            Console.ReadKey();
        }
    }
}
