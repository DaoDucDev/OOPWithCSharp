using System;
using System.Collections.Generic;
using System.Linq;

namespace SS8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student std = new Student();
            // std.Name = "dao van duc";  //set

            // Console.WriteLine(std.Name); //get

            //Quản lý một danh sách Student
            //Generic giúp định kiểu cho các phần tử của collection

            List<Student> listStudents = new List<Student>();

            listStudents.Add(new Student(1, "Dao Van X", 10));
            listStudents.Add(new Student(2, "Dao Van A", 5));
            listStudents.Add(new Student(3, "Dao Van T", 8.5));
            listStudents.Add(new Student(4, "Dao Van Z", 9.5));
            listStudents.Add(new Student(5, "Dao Van E", 7));

            //Sắp xếp dùng Lambda Expression
            //listStudents.Sort((x, y) => x.Name.CompareTo(y.Name));

            //Sắp xếp dùng IComparer
            //listStudents.Sort(new Student());

            //Sắp xếp dùng IComparable
            listStudents.Sort();
            
            //Tim nguoi cao diem nhat
            listStudents.Max(std => std.MathScore);

            //Tim nhung nguoi co diem > 5
            // var listHightScore = from Student in listStudents
            //                      where Student.MathScore > 5
            //                      select Student;

            List<Student> listHightScore = listStudents.FindAll(std => std.MathScore > 5);

            // foreach (Student std in listHightScore)
            // {
            //     Console.WriteLine("Name: {0}\nScore: {1}", std.Name, std.MathScore);
            // }
            

            int a = 1, b = 2;
            double num1 = 0.1, num2 = 0.2;
            Swap<int>(ref a, ref b);
            Swap<double>(ref num1, ref num2);
            
            Console.WriteLine("a = {0}\nb = {1}", a, b);

        }

        //Phương thức Generic
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
