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

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPanel(new RegistrarCliente());
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void abrirPanel(object panel) {

            if (this.panel1.Controls.Count > 0) {
                this.panel1.Controls.RemoveAt(0);
               }
            Form fh = panel as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            fh.Show();
        }

        private void administrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
