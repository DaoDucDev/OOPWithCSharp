using System;

namespace SS9
{
    class Program
    {
        delegate int DaoDucDevDelegate(string s);

        static void Main(string[] args)
        {
            // string strNum = "12345";
            // DaoDucDevDelegate devDelegate = new DaoDucDevDelegate(ConvertStringToInt);
            // int result = devDelegate(strNum);

            // Console.WriteLine("Sau khi convert: {0}", result);

            Employee emp = new Employee();


            string countryCode = "CN";
            double salary = 10000000;

            Employee.Tax t = emp.GetTax(countryCode);
            double s = t(salary);

            Console.WriteLine(s);
        }

        static int ConvertStringToInt(string strNum)
        {
            int value = 0;

            Int32.TryParse(strNum, out value);
            Console.WriteLine("Done");

            return value;
        }
    }
}
