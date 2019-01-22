using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectoSoftware
{
    class ConexionSqlServer
    {
        //public  SqlConnection cn;


        //public ConexionSqlServer()
        //{

        //}

        //public SqlConnection conectar()
        //{
        //    try
        //    {
        //         cn = new SqlConnection("Data Source=.;Initial Catalog=varadero;Integrated Security=True");
        //        cn.Open();
        //        Console.WriteLine("conectado");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("no se conecto"+ ex);
        //    }
        //    return cn;

        //}    


        static private string CadenaConexion = "Data Source=.;Initial Catalog=varadero;Integrated Security=True";
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataTable dt;
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public void select(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select *from Usuario", Conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                Console.WriteLine("error"+ex);
            }

        }

        public void Mostrar(DataGridView dgv, String buscador)
        {
            try
            {

                if (buscador == "")
                {
                    da = new SqlDataAdapter("select *from Usuario", Conexion);
                    
                }
                else
                {
                    da = new SqlDataAdapter("select *from Usuario where pnombre= '" + buscador + "'", Conexion);

                }
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
            }

        }

    }
}
