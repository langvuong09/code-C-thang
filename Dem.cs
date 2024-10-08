using System;

public class Dem
{
    public void dem()
    {
        string[] numberWords = { "", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };

        Console.Write("Nhap vao mot so tu 1 den 9: ");  // Sửa từ "đen" thành "đến"
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 9)
        {
            Console.WriteLine(numberWords[number]);
        }
        else
        {
            Console.WriteLine("So ngoai pham vi 1-9");
        }
    }
}
