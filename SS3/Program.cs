using System;

namespace SS3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mảng trong C#

            //Khai báo mảng
            //kiểu_dữ_liệu[] tên_mảng;

            //Khai báo và khởi tạo
            //kiểu_dữ_liệu[] tên_mảng = new kiểu_dữ_liệu[kích_thước_mảng];

            int[] ArrNum = new int[10];

            for (int i = 0; i < 10; i++)
            {
                ArrNum[i] = i + 5;
            }

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.Write(ArrNum[i] + "\t");
            // }


            //Khai báo và gán giá trị luôn
            double[] ArrDouble = {1.1, 1.2, 1.3, 1.4, 1.5};

            //Gán giá trị của 1 mảng cho mảng khác
            int[] arr1 = {1, 2, 3, 4, 5};
            int[] arr2 = arr1;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr2[i] + "\t");
            }
        }
    }
}
