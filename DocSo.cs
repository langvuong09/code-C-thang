using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DocSo
{
    public void docSo()
    {
        Console.Write("Nhap vao so tu 0 đen 999: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0 && number < 10)
        {
            Console.WriteLine(SoDon(number));
        }
        else if (number >= 10 && number < 20)
        {
            Console.WriteLine(Teens(number));
        }
        else if (number >= 20 && number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;
            Console.WriteLine(SoTronChuc(tens) + (ones > 0 ? " " + SoDon(ones) : ""));
        }
        else if (number >= 100 && number < 1000)
        {
            int hundreds = number / 100;
            int remainder = number % 100;

            string result = SoDon(hundreds) + " hundred";

            if (remainder > 0)
            {
                if (remainder < 10)
                {
                    result += " and " + SoDon(remainder);
                }
                else if (remainder < 20)
                {
                    result += " and " + Teens(remainder);
                }
                else
                {
                    int tens = remainder / 10;
                    int ones = remainder % 10;
                    result += " and " + SoTronChuc(tens) + (ones > 0 ? " " + SoDon(ones) : "");
                }
            }
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Out of ability");
        }
    }

    static string SoDon(int number)
    {
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }

    static string Teens(int number)
    {
        switch (number)
        {
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            default: return "";
        }
    }

    static string SoTronChuc(int tens)
    {
        switch (tens)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "forty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            case 9: return "ninety";
            default: return "";
        }
    }
}
