using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DemoWorkingWithJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cài NewtonSoft
            //dotnet add package NewtonSoft.Json

            List<Student> listStudents = new List<Student>();

            listStudents.Add(new Student("Dao Van A", 21, "Thai Binh"));
            listStudents.Add(new Student("Dao Van B", 21, "Ha Noi"));
            listStudents.Add(new Student("Dao Van C", 21, "Hai Phong"));
            listStudents.Add(new Student("Dao Van D", 21, "Thanh Hoa"));
            listStudents.Add(new Student("Dao Van E", 21, "Nghe An"));

            //Chuyển collection -> JSON Text
            string jsonText = JsonConvert.SerializeObject(listStudents);

            Console.WriteLine(jsonText);
            
            //Chuyển text json -> collection
            List<Student> listFromJsonText = JsonConvert.DeserializeObject<List<Student>>(jsonText);
        }
    }
}
