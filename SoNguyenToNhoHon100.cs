using System;

class SoNguyenToNhoHon100
{
    public void soNguyenToNhoHon100()
    {
        Console.WriteLine("Cac so nguyen to nho hon 100 la:");
        for (int num = 2; num < 100; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
