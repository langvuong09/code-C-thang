using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public class TimSoLonNhat(){
    public void timSoLonNhat(){
        Console.Write("Nhap so n: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for(int i=0;i<n;i++){
            a[i] = int.Parse(Console.ReadLine());
        }

        int max = a[0];
        for(int i=1;i<n;i++){
            if(max < a[i]){
                max = a[i];
            }
        }

        Console.Write("So lon nhat la: "+max);
    }
}