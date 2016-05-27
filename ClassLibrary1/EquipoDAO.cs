﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAcces;
using System.Data.OleDb;

namespace DataAcces
{
   public class EquipoDAO
    {

       public List<Equipo> GetEquipos()
       {
           string query = "SELECT * FROM Equipos";
           List<Equipo> equipos = tratarResultadoEquipo(query);

           return equipos;
       }


       public List<Equipo> tratarResultadoEquipo(string query)
        {
            List<Equipo> equipos = new List<Equipo>();
            OleDbDataReader dr = new ConnectionDAO().consulta(query);
            while (dr.Read())
            {
                Equipo equipo = new Equipo() { Nombre = (string)dr["Nombre"], Archivo = (string)dr["Archivo"] };
                equipos.Add(equipo);
            }
            dr.Close();
            return equipos;
        }


       








    }
}