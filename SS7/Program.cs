using System;
using System.Collections;
using System.Collections.Generic;
using SS7Plus;


namespace SS7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student std = new Student();

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(std[i]);
            // }

            //SS7Plus.Program program = new SS7Plus.Program();

            // int num1, num2;

            // Console.Write("Nhap so nguyen thu nhat: ");
            // num1 = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Nhap so nguyen thu hai : ");
            // num2 = Convert.ToInt32(Console.ReadLine());
            // int result = 0;
            // try
            // {
            //     //Đoạn code có khả năng gây ra exception
            //     result = num1 / num2;
            // }
            // catch (System.DivideByZeroException ex)
            // {
            //     Console.WriteLine("Loi: " + ex.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("{0}/{1} = {2}", num1, num2, result);
            // }

            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add("Dao Van Duc");
            list.Add(new Person());
            list.Add('X');

            Console.WriteLine(list[1]);

            //List<Person> listPersons = new List<Person>();

            SortedList sortedList = new SortedList();

            sortedList.Add(1, "ABC");

        }
    }
}


