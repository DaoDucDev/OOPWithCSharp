using System;
using System.Threading;

namespace SS10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gọi và thực thi theo cách tuần tự
            //Tốn 15s để thực thi 3 method.
            // DemoThread();
            // DemoThread();
            // DemoThread();

            //Tạo thread để chạy các method song song

            // Thread t1 = new Thread(() =>
            // {
            //     DemoThread("Thread 1");
            // });
            // //Thread chỉ bắt đầu thực thi khi gọi phương thức Start()
            // t1.Start();

            // Thread t2 = new Thread(() =>
            // {
            //     DemoThread("Thread 2");
            // });
            // //Thread chỉ bắt đầu thực thi khi gọi phương thức Start()
            // t2.Start();

            // Thread t3 = new Thread(() =>
            // {
            //     DemoThread("Thread 3");
            // });
            // //Thread chỉ bắt đầu thực thi khi gọi phương thức Start()
            // t3.Start();

            for (int i = 0; i < 5; i++)
            {
                int temp = i;
                Thread t = new Thread(() =>
                {
                    DemoThread("Thread " + temp);
                });
                
                t.Start();
            }

            //Nếu thread xử lý nhiều hoặc vô tận, nên set thuộc tính IsBackground = true
            //Nếu IsBackground  = true thì thread sẽ dc tự động giải phóng khi tắt chương trình
            //Nếu ko thì chương trình phải đợi thread thực hiện xong mới dc kết thúc

        }

        public static void DemoThread(string nameThread)
        {
            for (int i = 0; i < 1000; i++)
            {
                //Thread.Sleep(1000); //Giả lập thời gian thực thi tác vụ
                Console.WriteLine(nameThread + " - " + i);
            }
        }
    }
}
