using System;
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
           InsertEmployee("John Doe", 30000.00m, 'F');
            InsertEmployee("Jane Smith", 28000.00m, 'P');
            InsertEmployee("Michael Johnson", 32000.00m, 'F');

            DisplayAllEmployees();

            Console.ReadLine();
        }
       
        private static SqlConnection GetConnection()
        {
            string connectionString = "data source=ICS-LT-98M46D3;initial catalog=Employeemanagement;user id=sa;password=pretheeba;";
            con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public static void InsertEmployee(string empName, decimal empsal, char emptype)
        {
            con = GetConnection();

            cmd = new SqlCommand("AddEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpName", empName);
            cmd.Parameters.AddWithValue("@Empsal", empsal);
            cmd.Parameters.AddWithValue("@Emptype", emptype);

            int empno = (int)cmd.ExecuteScalar();
            Console.WriteLine($"Employee added with Empno: {empno}");

            con.Close();
        }

        public static void DisplayAllEmployees()
        {
            con = GetConnection();
            cmd = new SqlCommand("SELECT Empno, EmpName, Empsal, Emptype FROM Employee_Details", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"{dr["Empno"]} | {dr["EmpName"]} | {dr["Empsal"]} | {dr["Emptype"]}");
            }

            dr.Close();
            con.Close();
        }
    }
}
