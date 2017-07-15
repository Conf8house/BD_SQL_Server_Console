using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Connection = new System.Data.SqlClient.SqlConnection();
            Connection.ConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DB_SQL_SERVER.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";//"Data Source =\"E:\\DB_SQL_Server.mdf\"";
            Connection.Open();
            var Command = new System.Data.SqlClient.SqlCommand();

        }
    }
}
