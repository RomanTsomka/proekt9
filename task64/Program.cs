// Задача 64: Задайте значения M и N. 
// Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Recurs(m, n);

        void Recurs(int m, int n)
        {
            if (m > n) return;
            if (m % 3 == 0)
                Console.WriteLine($"{m} ");
            m++;
            Recurs(m, n);

        }
    }
}