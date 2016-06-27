using DataAcces;
using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class TemporadaActualDAO
    {
        public int GetTemporadaActual()
        {

            string query = "SELECT Valor FROM Variables WHERE Variable = 'TemporadaActual'";
            int temp= 0;
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            
            while (dr.Read())
            {


                temp =  (int)dr["Valor"];




            }

            dr.Close();




            return temp;
        }

    }
}
