using System;

class Sao{
    public void sao(){
        int check = 0;
        do{
            Console.WriteLine("1. In hinh vuong");
            Console.WriteLine("2. In hinh tam giac vuong (botton-left)");
            Console.WriteLine("3. In hinh vuong can");
            Console.WriteLine("-----Nhan so 0 de thoat-----");
            Console.Write("Chon: ");
            check = int.Parse(Console.ReadLine());
            switch(check){
                case 1:
                    Console.Write("Nhap chieu dai: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    int b = int.Parse(Console.ReadLine());
                    for(int i=0;i<b;i++){
                        for(int j=0;j<a;j++){
                            Console.Write("* ");
                        }
                        Console.WriteLine("");
                    }
                    break;
                case 2:
                    Console.Write("Nhap chieu cao: ");
                    int h = int.Parse(Console.ReadLine());
                    for(int i=1;i<=h;i++){
                        for(int j=0;j<i;j++){
                            Console.Write("* ");
                        }
                        Console.WriteLine("");
                    }
                break;
                case 3:
                    Console.Write("Nhap chieu cao: ");
                    int ah = int.Parse(Console.ReadLine());
                    for(int i=1;i<=ah ;i++){
                        for(int j=1;j<=ah-i;j++){
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= 2 * i - 1; k++){
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
            }

        }while(check != 0);
    }
}