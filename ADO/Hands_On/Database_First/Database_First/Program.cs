using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_First
{
    class Program
    {
        //let us create an object of the context class
        static infiniteDB db = new infiniteDB();
        static void Main(string[] args)
        {
            var emp = db.employees.ToList();

            foreach (var e in emp)
            {
                Console.WriteLine(e.empid + " " + e.empname + " " + e.salary);
            }

            Console.Read();
        }
    }
}