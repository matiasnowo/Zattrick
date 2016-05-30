
using System.Data.OleDb;

namespace DataAcces
{
    public class ConnectionDAO
    {
        public OleDbConnection getConnectionSQL()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Zattrick.mdb;";
            OleDbConnection conn = new OleDbConnection(connectionString);
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
