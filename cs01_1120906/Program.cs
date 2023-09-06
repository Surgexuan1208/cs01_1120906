// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main()
    {
        Console.WriteLine("請輸入一個整數n:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++) { 
                Console.WriteLine($"{i}*{j}={i * j}");
            }
            Console.WriteLine();
        }
    }
}