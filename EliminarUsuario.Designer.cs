namespace ProyectoSoftware
{
    partial class EliminarUsuario
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
            this.eliminar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.elimiUsuario = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(243, 314);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 1;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(460, 314);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Atras";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Usuario";
            // 
            // elimiUsuario
            // 
            this.elimiUsuario.Location = new System.Drawing.Point(309, 50);
            this.elimiUsuario.Name = "elimiUsuario";
            this.elimiUsuario.Size = new System.Drawing.Size(226, 20);
            this.elimiUsuario.TabIndex = 4;
            this.elimiUsuario.TextChanged += new System.EventHandler(this.eliminar_TextChanged);
            this.elimiUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.elimiUsuario_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 193);
            this.dataGridView1.TabIndex = 6;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.elimiUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarUsuario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox elimiUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}