//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collection
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> list = new List<int>();
//            list.Add(1);
//            list.Add(2);
//            list.Add(3);
//            list.Add(4);
//            List<String> list2 = new List<String>();
//            list2.Add("a");
//            list2.Add("b");
//            list2.Add("c");
//            List<String> list3 = new List<String>();
//            list3.Add("d");
//            list3.Add("e");
//            list3.Add("f");
//            foreach (int i in list)
//            {
//                // Console.Write(i);
//            }
//            Console.WriteLine(list[1]);
//            Console.WriteLine(list.Count);
//            list.Insert(4, 5);
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }
//            list2.InsertRange(2, list3);
//            list2.AddRange(list3);
//            Console.WriteLine(list2.Count);
//            list2.Remove(list2[1]);
//            int index = list2.IndexOf("a");
//            Console.WriteLine(index);
//            Console.WriteLine(list2.LastIndexOf("a"));
//            list.Sort();
//        }
//    } 
//}
