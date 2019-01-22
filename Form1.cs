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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mostrarInstalacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.WindowState = FormWindowState.Maximized;
            Reporte repor = new Reporte();
            repor.TopLevel = false;
            repor.Dock = DockStyle.Fill;
            repor.AutoSize = false;
            repor.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(repor);
            this.panelContenedor.Tag = repor;
            repor.Show();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verParametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.WindowState = FormWindowState.Maximized;
            Parametros par = new Parametros();
            par.TopLevel = false;
            par.Dock = DockStyle.Fill;
            par.AutoSize = false;
            par.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.panelContenedor.Controls.Add(par);
            this.panelContenedor.Tag = par;
           
            par.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
