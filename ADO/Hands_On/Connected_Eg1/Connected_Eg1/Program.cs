using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Connected_Eg1
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
           // SelectData();
           // Select_With_Parameter();
            UpdateData();
            Console.ReadLine();

        }
        // database connection 
        private static SqlConnection getconnection()
        {
            con = new SqlConnection("data source = ICS-LT-98M46D3 ; initial catalog = infiniteDB ;" + "user id = sa ; password = pretheeba ;");
            con.Open();
            return con;
        }
        // function for execution of select statement

        public static void SelectData()
        {
            con = getconnection();
            cmd = new SqlCommand("select * from employees", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " | " + dr[1] + " | " + dr[2] + " | " + dr[3]);
            }
        }
        public static void Select_With_Parameter()
        {
            con = getconnection();
            int dept_id;
            Console.WriteLine("mention the dept_no : ");
            dept_id = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("select * from employees where dept_no = @did ");

            //associate C# variable with sql data 
            cmd.Parameters.AddWithValue("@did", dept_id);
            cmd.Connection = con;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " | " + dr[1] + " | " + dr[2] + " | " + dr[3] + " | " + dr[4] + " | " + dr[5]);
            }
        }
        public static void UpdateData()
        {
            con = getconnection();

            Console.WriteLine("Enter number to update for department:");

            int deptno = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter new name for department:");

            string newDeptName = Console.ReadLine();

            cmd = new SqlCommand("Update dept set dept_name = @newdeptname where dept_no = @deptno", con);

            cmd.Parameters.AddWithValue("@deptno", deptno);


            cmd.Parameters.AddWithValue("@newdeptname", newDeptName);

            dr = cmd.ExecuteReader();

            if (dr > 0)

                Console.WriteLine("success");

            else

                Console.WriteLine("not updated");
        }

    }
}