//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collection
//{
//    class Employee
//    {
//        static void Main(string[] args)
//        {
//           Dictionary<String,String>  EmployeeList = new Dictionary<String,String>();
//            EmployeeList.Add("viraat","player");
//            EmployeeList.Add("Allu arjun", "actor");
//            Dictionary<String ,int> a= new Dictionary<String ,int>();
//            a.Add("sai ", 1);
//            a.Add("prabhas", 2);
//            a["ram"] = 3;           
//            a["rama"] = 4;
//            if (!a.ContainsKey("rama"))
//            {
//                a["mahesh"] = 5;
//            }
//            if (!a.ContainsValue(0))
//            {
//                Console.WriteLine("no");
//            }
//            foreach (KeyValuePair<String, int> key in a)
//            {
//                Console.WriteLine(key.Key + " " + key.Value);
//            }
//            Console.Write(a.Count());
//        }
//    }
//}
