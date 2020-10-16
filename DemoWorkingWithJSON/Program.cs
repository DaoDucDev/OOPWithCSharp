using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

            WorkingWithFile wwf = new WorkingWithFile();

            //wwf.WriteTextIntoFile("data.json", jsonText);
            
            string textDataFromFile = wwf.ReadTextFromFile("data.json");
            //Chuyển text json -> collection
            List<Student> listFromJsonText = JsonConvert.DeserializeObject<List<Student>>(textDataFromFile);

            listFromJsonText.Add(new Student("JAV", 22, "Ha Noi"));
            jsonText = JsonConvert.SerializeObject(listFromJsonText);

            wwf.WriteTextIntoFile("data.json", jsonText);

            Student std = new Student();
            std.Subjects[0] = new Subject();

        }
    }
}
