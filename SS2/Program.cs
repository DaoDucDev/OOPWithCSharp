using System;

namespace SS2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Viết code ở trong phương thức main này!
            // int a, b, c;
            // double num1, num2, num3;
            // char c1 = 'A'; //Nháy đơn là dùng cho kiểu char, lưu trữ 1 kí tự
            // bool xxx = true;

            // //Nháy kép là dùng cho string, lưu trữ một chuỗi kí tự
            // string FullName = "Dao Van Duc";

            // var bt1 = 1.1;

            //Nhập dữ liệu từ bàn phím
            //Console.ReadLine() //Kết thúc việc nhập khi bấm enter

            //In ra màn hình console
            //Console.Write(); //Không xuống dòng
            //Console.WriteLine(); //In xong sẽ tự động xuống dòng
            //int a = 1 + 1;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string name;

            Console.Write("Nhập tên của bạn: ");
            name = Console.ReadLine();

            Console.WriteLine("Xin chào {0}", name);

            Console.Write("Mày sinh năm bao nhiêu: ");
            //int BirthYear = Convert.ToInt32(Console.ReadLine()); //C1
            uint BirthYear = UInt32.Parse(Console.ReadLine()); //C2

            int age = Convert.ToInt32(DateTime.Now.Year - BirthYear);

            Console.WriteLine("Xin chào {0}. Năm nay bạn đã {1} tuổi!", name, age);

            if (age > 25)
            {
                Console.WriteLine("Vậy chắc mày đi làm rồi nhỉ! Thế đã có vợ chưa?!(Y/N)");
                Console.Write("Trả lời: ");
                char answer = Convert.ToChar(Console.ReadLine());

                switch (answer)
                {
                    case 'Y':
                    case 'y':
                        Console.WriteLine("Ngon! Chúc mày hạnh phúc");
                        break;
                    case 'N':
                    case 'n':
                        if(25 <= age && age <= 30)
                        {
                            Console.WriteLine("Thế thì kiếm vợ nhanh đi!");
                        }
                        else
                        {
                            Console.WriteLine("Thế thì chắc ế cmnr! :v ");
                        }
                        break;
                    default:
                        break;
                }
            }

            //For, while, do...while
        }
    }
}
