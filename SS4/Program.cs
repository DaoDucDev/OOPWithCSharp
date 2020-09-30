using System;

namespace SS4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            
            //Tạo object từ class
            // Student std1 = new Student();

            // Console.Write("Nhập tên của bạn: ");
            // std1.Name = Console.ReadLine();
            // std1.SayHello();

            // Cat newCat = new Cat();
            // newCat.Name = "Mỡ";

            // newCat.Run();

            Rectangle rec1 = new Rectangle();
            
            Console.Write("width     : ");
            rec1.setWidth(Int32.Parse(Console.ReadLine()));

            Console.Write("height    : ");
            rec1.setHeight(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Area     : {0}", rec1.getArea());
            Console.WriteLine("Perimeter: {0}", rec1.getPerimiter());
            rec1.display();

            Rectangle[] listRecs = new Rectangle[5];

            listRecs[0] = new Rectangle(10, 15);
        }
    }

    
}
