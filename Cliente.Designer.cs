namespace ProyectoSoftware
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cedC = new System.Windows.Forms.TextBox();
            this.nompC = new System.Windows.Forms.TextBox();
            this.nomsC = new System.Windows.Forms.TextBox();
            this.apellpC = new System.Windows.Forms.TextBox();
            this.apellsC = new System.Windows.Forms.TextBox();
            this.dirC = new System.Windows.Forms.TextBox();
            this.telC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // cedC
            // 
            this.cedC.Location = new System.Drawing.Point(40, 73);
            this.cedC.Name = "cedC";
            this.cedC.Size = new System.Drawing.Size(206, 20);
            this.cedC.TabIndex = 5;
            this.cedC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nompC
            // 
            this.nompC.Location = new System.Drawing.Point(40, 150);
            this.nompC.Name = "nompC";
            this.nompC.Size = new System.Drawing.Size(100, 20);
            this.nompC.TabIndex = 6;
            this.nompC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // nomsC
            // 
            this.nomsC.Location = new System.Drawing.Point(146, 150);
            this.nomsC.Name = "nomsC";
            this.nomsC.Size = new System.Drawing.Size(100, 20);
            this.nomsC.TabIndex = 7;
            this.nomsC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // apellpC
            // 
            this.apellpC.Location = new System.Drawing.Point(296, 150);
            this.apellpC.Name = "apellpC";
            this.apellpC.Size = new System.Drawing.Size(100, 20);
            this.apellpC.TabIndex = 8;
            this.apellpC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // apellsC
            // 
            this.apellsC.Location = new System.Drawing.Point(402, 150);
            this.apellsC.Name = "apellsC";
            this.apellsC.Size = new System.Drawing.Size(100, 20);
            this.apellsC.TabIndex = 9;
            this.apellsC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // dirC
            // 
            this.dirC.Location = new System.Drawing.Point(40, 232);
            this.dirC.Name = "dirC";
            this.dirC.Size = new System.Drawing.Size(100, 20);
            this.dirC.TabIndex = 10;
            this.dirC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // telC
            // 
            this.telC.Location = new System.Drawing.Point(40, 302);
            this.telC.Name = "telC";
            this.telC.Size = new System.Drawing.Size(100, 20);
            this.telC.TabIndex = 11;
            this.telC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 386);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telC);
            this.Controls.Add(this.dirC);
            this.Controls.Add(this.apellsC);
            this.Controls.Add(this.apellpC);
            this.Controls.Add(this.nomsC);
            this.Controls.Add(this.nompC);
            this.Controls.Add(this.cedC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cedC;
        private System.Windows.Forms.TextBox nompC;
        private System.Windows.Forms.TextBox nomsC;
        private System.Windows.Forms.TextBox apellpC;
        private System.Windows.Forms.TextBox apellsC;
        private System.Windows.Forms.TextBox dirC;
        private System.Windows.Forms.TextBox telC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}