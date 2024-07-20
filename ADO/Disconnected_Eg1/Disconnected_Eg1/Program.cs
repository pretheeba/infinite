using System.Data;
using System;
using System.Data.SqlClient;

namespace Disconnected_Eg1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlDataAdapter da;
        static void Main(string[] args)
        {
            Disconnected_approach();
            Console.Read();
        }

        public static void Disconnected_approach()
        {
            con = new SqlConnection("data source=ICS-LT-98M46D3; initial catalog=northwind;" + " user id=sa; password=pretheeba;");

            con.Open();
            da = new SqlDataAdapter("select * from Region", con);
            DataSet ds = new DataSet();

            da.Fill(ds, "NorthwindRegion");
            DataTable dt = ds.Tables["NorthwindRegion"];

            //to access the rows and columns from the datatable
            foreach (DataRow drow in dt.Rows)
            {
                foreach (DataColumn dcol in dt.Columns)
                {
                    Console.Write(drow[dcol]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
