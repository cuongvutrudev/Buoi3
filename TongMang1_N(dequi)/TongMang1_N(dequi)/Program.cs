using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongMang1_N_dequi_
{
    class Program
    {
        public static int SumArray(int[] arr, int left, int right)
        {
            if (left == right)
                return arr[left];
            else
            {
                int mid = (left + right) / 2;
                return SumArray(arr, left, mid) + SumArray(arr, mid + 1, right); //goi lai 
            }
        }
        static void Main(string[] args)
        {
             Console.Write("Nhap so phan tu n cua mang: ");
             int n = int.Parse(Console.ReadLine());

             int[] arr = new int[n];

            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ",i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = SumArray(arr, 0, n - 1);
            Console.WriteLine("Tong cac phan tu trong mang tu 1 đen {0} la: {1}",n,sum);
            Console.ReadKey();
        }
    }
}
