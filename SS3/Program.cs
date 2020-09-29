using System;

namespace SS3
{
    class Program
    {
        enum DaysOfWeek
        {
            T2 = 1, T3 = 2, T4 = 3, T5 = 4, T6 = 5, T7 = 6, CN = 7
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int t2 = (int)DaysOfWeek.T2;
            Console.WriteLine("Ngày đầu tuần {0}", t2);
            //Mảng trong C#

            //Khai báo mảng
            //kiểu_dữ_liệu[] tên_mảng;

            //Khai báo và khởi tạo
            //kiểu_dữ_liệu[] tên_mảng = new kiểu_dữ_liệu[kích_thước_mảng];

            // int[] ArrNum = new int[10];

            // for (int i = 0; i < 10; i++)
            // {
            //     ArrNum[i] = i + 5;
            // }

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.Write(ArrNum[i] + "\t");
            // }


            //Khai báo và gán giá trị luôn
            // double[] ArrDouble = {1.1, 1.2, 1.3, 1.4, 1.5};

            // //Gán giá trị của 1 mảng cho mảng khác
            // int[] arr1 = {1, 2, 3, 4, 5};
            // int[] arr2 = arr1;

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.Write(arr2[i] + "\t");
            // }

            //String trong C#
            //String là 1 kiểu dữ liệu và nó là kiểu tham chiếu
            
            // string str = "Đào     Văn Đức";
            // Console.WriteLine(str);

            // string[] name = {"Đào", "Văn", "Đức"};
            // var fullName = String.Join(" ", name);
            // Console.WriteLine(fullName);

            //Console.WriteLine(str.ToUpper());
            //Contains() kiểm tra chuỗi con có tồn tại trong chuỗi cha hay ko
            // Console.WriteLine(str.Contains("Đào"));

            //Replace() thay thế kí tự hoặc chuỗi con trong chuỗi cha
            //str = str.Replace('Đ', 'T').Replace("Tức", "Đức đẹp trai");

            // Console.Write("Nhập một chuỗi bất kì: ");
            // string xxx = Console.ReadLine();

            // Console.WriteLine(str.Replace("Đức", xxx));

            //Chia chuỗi cha thành mảng các chuỗi
            // str.Split(' ');

            //Trim() loại bỏ khoảng trắng ở đầu hoặc cuối chuỗi
            // string xyz = "     Đào Văn Đức    ";
            // Console.WriteLine(xyz.Trim());

            //SubString(): Cắt chuỗi
            //IndexOf(): trả về vị trí đầu tiên của kí tự hoặc chuỗi
            //trong chuỗi cha.

            //string abc = "Đào Văn Đức (28)";

            //Console.WriteLine(abc.IndexOf("("));
            //Console.WriteLine(abc.Substring(abc.IndexOf("(") + 1, 2));

            //(((abc)))
            //Regex: best performance nhưng khó (RẤT KHÓ)


        }
    }
}
