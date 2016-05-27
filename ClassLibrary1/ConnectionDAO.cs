using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DataAcces
{
    public class ConnectionDAO
    {


        public OleDbConnection getConnectionSQL()
        {

            
          string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Zattrick.mdb;";
          //   string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\matia\Dropbox\3. Zattrick\5. C# - Zattrick\Solution1\ClassLibrary1\Zattrick.mdb;";

            OleDbConnection conn = new OleDbConnection(connectionString);
           
                //datattec
               //otros
                //string connectionString = "Data Source=localhost;Initial Catalog=Ambulancias;Integrated Security=SSPI";
                conn.Open();     


            return conn;
        }


        public OleDbDataReader consulta(string query)
        {

            OleDbConnection conn = new ConnectionDAO().getConnectionSQL();
            OleDbCommand cm = new OleDbCommand(query, conn);
           
            OleDbDataReader dr = cm.ExecuteReader();

            return dr;

           
        }

        public void queryABM(string query)
        {

            OleDbConnection conn = new ConnectionDAO().getConnectionSQL();
            OleDbCommand cm = new OleDbCommand(query, conn);
            cm.ExecuteNonQuery();
            conn.Close();
        }


    }
}
