using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection conexion;


        public SqlConnection Conexion => conexion;


        public void Open()
        {
            const string cns = @"Integrated Security=SSPI;Data Source=.\SQLEXPRESS;Initial Catalog=VisitorTienda";
            conexion = new SqlConnection(cns);
            conexion.Open();
        }
        public void Close()
        {
            if (conexion != null)
            {
                conexion.Close();
                conexion.Dispose();
                conexion = null;
                GC.Collect();
            }
        }
        private SqlCommand CreateCommand(string nombre, List<SqlParameter> pars = null)
        {
            var cmd = new SqlCommand(nombre, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            if (pars != null && pars.Count > 0)
                cmd.Parameters.AddRange(pars.ToArray());

            return cmd;
        }
        public DataTable Read(string nombre, List<SqlParameter> pars = null)
        {
            var tabla = new DataTable();
            using (var da = new SqlDataAdapter())
            {
                da.SelectCommand = CreateCommand(nombre, pars);
                da.Fill(tabla);
            }
            return tabla;
        }
        public int Write(string nombre, List<SqlParameter> pars = null)
        {
            int filasAfectadas;
            using (var cmd = CreateCommand(nombre, pars))
            {
                try
                {
                    filasAfectadas = cmd.ExecuteNonQuery();
                }
                catch
                {
                    filasAfectadas = -1;
                }
            }
            return filasAfectadas;
        }
        public object WriteScalar(string nombre, List<SqlParameter> pars = null)
        {
            object retorno;
            using (var cmd = CreateCommand(nombre, pars))
            {
                try
                {
                    retorno = cmd.ExecuteScalar();
                }
                catch
                {
                    retorno = "-1";
                }
            }
            return retorno;
        }

       

        public SqlParameter CreateParameter(string nombre, string valor)
        {
            var parametro = new SqlParameter(nombre, valor)
            {
                DbType = DbType.String
            };
            return parametro;
        }
        public SqlParameter CreateParameter(string nombre, decimal valor)
        {
            var parametro = new SqlParameter(nombre, valor)
            {
                DbType = DbType.Decimal
            };
            return parametro;
        }

        public SqlParameter CreateParameter(string nombre, int valor)
        {
            var parametro = new SqlParameter(nombre, valor)
            {
                DbType = DbType.Int32
            };
            return parametro;
        }

        public SqlParameter CreateParameter(string nombre, float valor)
        {
            var parametro = new SqlParameter(nombre, valor)
            {
                DbType = DbType.Single
            };
            return parametro;
        }

        public SqlParameter CreateParameter(string nombre, long valor)
        {
            var parametro = new SqlParameter(nombre, valor)
            {
                DbType = DbType.Int64
            };
            return parametro;
        }

        
    }
}
