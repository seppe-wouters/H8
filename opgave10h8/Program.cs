namespace opgave10h8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] getallen = new int[n];

            Console.WriteLine("geef nu n aantal getallen: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("> ");
                getallen[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine($"kleinste getal: {getallen.Min()}");
            Console.WriteLine($"grootste getal: {getallen.Max()}");

            for (int i = 0; i < getallen.Length; i++)
            {
                
            }
        }
    }
}