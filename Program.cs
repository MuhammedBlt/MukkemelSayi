
class Program
{
    static void Main()
    {
        int limit = 1000;
        int perfectCount = 0; 

        Console.WriteLine($"1000'e kadar olan mükemmel sayılar:");
        for (int i = 1; i <= limit; i++)
        {
            int perfectNumber = IsPerfectNumber(i);
            if (perfectNumber != 0)
            {
                Console.WriteLine(perfectNumber);
                perfectCount++;
            }
        }

        Console.WriteLine($"Toplam mükemmel sayı sayısı: {perfectCount}");
    }

    static int IsPerfectNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return (sum == number) ? number : 0;
    }
}
