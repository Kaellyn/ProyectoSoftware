using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSoftware
{
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
