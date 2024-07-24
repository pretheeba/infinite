using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_sql
{
    class Program
    {
        static LSCDataContext dc = new LSCDataContext();
        static void Main(string[] args)
        {
            var emp = dc.employee.ToList();

            foreach (var e in emp)
            {
                Console.WriteLine($"empid {e.empid}, empname {e.empname} and salary is {e.salary}");
            }
            Console.Read();
        }
    }
}