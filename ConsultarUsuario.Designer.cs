namespace ProyectoSoftware
{
    partial class ConsultarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableConsultar = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarUsuario = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableConsultar
            // 
            this.tableConsultar.ColumnCount = 1;
            this.tableConsultar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableConsultar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableConsultar.Location = new System.Drawing.Point(0, 60);
            this.tableConsultar.Name = "tableConsultar";
            this.tableConsultar.RowCount = 1;
            this.tableConsultar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableConsultar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableConsultar.Size = new System.Drawing.Size(799, 172);
            this.tableConsultar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // buscarUsuario
            // 
            this.buscarUsuario.Location = new System.Drawing.Point(103, 18);
            this.buscarUsuario.Name = "buscarUsuario";
            this.buscarUsuario.Size = new System.Drawing.Size(201, 20);
            this.buscarUsuario.TabIndex = 1;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(340, 270);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Atras";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.buscarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarUsuario";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscarUsuario;
        private System.Windows.Forms.Button Salir;
    }
}