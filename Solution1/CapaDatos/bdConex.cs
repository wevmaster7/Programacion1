﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class bdConex
    {
        String cadenaConex = "Data Source=.;Initial Catalog=hospital;User ID=parcial4;Password=123";
        SqlDataAdapter adaptador;
        SqlCommandBuilder comm;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        public SqlDataAdapter da; //******
        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }       
        public bool Conectar() {
            bool conn=false;
            try {
                conexion.ConnectionString = cadenaConex;
                conexion.Open();
                conn = true;
            }
            catch (Exception ex){
                conn = false;
            }
            return conn;
        }
        public void Desconectar() {
            conexion.Close();
        }

        public void consultaSQL(String consulta) {
            String mensaje = "Error";
            try {
                comando = new SqlCommand(consulta,conexion );
                comando.ExecuteNonQuery();
                mensaje = "Correctamente";
            
            }
            catch {
                mensaje = "Error";
            }

        }

        public void mostrarSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                da = new SqlDataAdapter(comando);
                mensaje = "Correctamente";

            }
            catch
            {
                mensaje = "Error";
            }

        }





    }
}
