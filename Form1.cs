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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Console.WriteLine("Hola");
            InitializeComponent();

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.TopLevel = false;
            bienvenida.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(bienvenida);
            this.panelContenedor.Tag = bienvenida;
            bienvenida.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            AsistenciasGimnasio asisGim = new AsistenciasGimnasio();
            asisGim.TopLevel = false;
            asisGim.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(asisGim);
            this.panelContenedor.Tag = asisGim;
            asisGim.Show();
        }
    }
}
