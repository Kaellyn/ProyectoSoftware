using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoftware
{
    public partial class ConsultarUsuario : Form
    {
        String consulUser;
        public ConsultarUsuario()
        {
            InitializeComponent();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulUser = conUsuario.Text;
            
           

                ConexionSqlServer con = new ConexionSqlServer();
                con.Mostrar(tableUsuario, consulUser);
        }

        private void conUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar validar = new Validar();
            validar.SoloLetras(e);
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            ConexionSqlServer con = new ConexionSqlServer();
            con.Mostrar(tableUsuario,"");
        }
    }
}
