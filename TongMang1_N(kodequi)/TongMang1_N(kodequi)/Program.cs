using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongMang1_N_kodequi_
{
    class Program
    {
        public static int SumOfArray(int[] arr,int n)
        {
            // Tạo mảng để lưu trữ kết quả
            int[] dp = new int[n + 1];// n =3+1= 4

            // Tính toán giá trị của từng phần tử trong mảng
            for (int i = 1; i <= n; i++)
            {
                dp[i] = dp[i - 1] + arr[i-1];
            }

            // Trả về kết quả là phần tử cuối cùng của mảng
            return dp[n];
        }
  
        static void Main(string[] args)
        {
            Console.Write("Muon bao nhieu phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = SumOfArray(arr,n);
            Console.WriteLine("Tong mang tu 1....{0} la :{1}", n,result);
            Console.ReadKey();
        }
    }
}
