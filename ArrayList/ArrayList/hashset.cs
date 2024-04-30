using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Employeee
    { 
        public int Id {  get; set; }    
        public string Name { get; set; }
        static void Main(string[] args)
        {
            String[] a = { "rama", "sai", "parushurama" };
            HashSet<string> set = new HashSet<string>(a);
            set.Add("rama");
            set.Add("sai");
            set.Add("rama");
            set.Add(null);
            set.Add(null);
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
            HashSet<string> list = new HashSet<string>(set);
            list.Add("allu arjun");
            list.Add("NTR");

            HashSet<Employeee> employeees = new HashSet<Employeee>
            {
                new Employeee{Id=1,Name="ANR"},
                new Employeee{Id=2,Name="Jr.NTR"},
                new Employeee{Id=2,Name="ANR" }
            };
            foreach (Employeee s in employeees)
            {
                Console.WriteLine(s.Id);
            }
        }
    }
}
