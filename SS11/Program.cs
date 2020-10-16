using System;
using System.IO;

namespace SS11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo luồng đọc/ghi file
            // FileStream file = new FileStream("thayducdeptrai.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // //Ghi dữ liệu vào file
            // for (int i = 0; i < 100; i++)
            // {
            //     file.WriteByte((byte)(i+5));
            // }

            // Console.WriteLine(file.Position);

            // //Đọc dữ liệu từ file ra.
            // file.Position = 0; //Set con trỏ về đầu file
            // for (int i = 0; i < 100; i++)
            // {
            //     int data = file.ReadByte();
            //     Console.Write(data + "\t");
            // }

            // //Đóng luồng
            // file.Close();

            using (FileStream file = new FileStream("thayducdeptrai.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //Ghi dữ liệu vào file
                for (int i = 0; i < 100; i++)
                {
                    file.WriteByte((byte)(i + 5));
                }

                Console.WriteLine(file.Position);

                //Đọc dữ liệu từ file ra.
                file.Position = 0; //Set con trỏ về đầu file
                for (int i = 0; i < 100; i++)
                {
                    int data = file.ReadByte();
                    Console.Write(data + "\t");
                }
            }
        }
    }
}
