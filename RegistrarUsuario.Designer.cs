namespace ProyectoSoftware
{
    partial class RegistrarUsuario
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
            this.vpasswordTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Verificar Password";
            // 
            // vpasswordTxt
            // 
            this.vpasswordTxt.Location = new System.Drawing.Point(24, 326);
            this.vpasswordTxt.Name = "vpasswordTxt";
            this.vpasswordTxt.Size = new System.Drawing.Size(159, 20);
            this.vpasswordTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(24, 259);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(159, 20);
            this.passwordTxt.TabIndex = 4;
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(24, 194);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(159, 20);
            this.loginTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cédula";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(24, 49);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(159, 20);
            this.nombreTxt.TabIndex = 9;
            this.nombreTxt.TextChanged += new System.EventHandler(this.nombreTxt_TextChanged);
            this.nombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTxt_KeyPress);
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(234, 49);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(159, 20);
            this.apellidoTxt.TabIndex = 10;
            this.apellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoTxt_KeyPress);
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.Location = new System.Drawing.Point(24, 124);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(159, 20);
            this.cedulaTxt.TabIndex = 11;
            this.cedulaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaTxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Teléfono";
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(234, 124);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(159, 20);
            this.telefonoTxt.TabIndex = 14;
            this.telefonoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonoTxt_KeyPress);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(234, 324);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 15;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(361, 326);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 16;
            this.Cancelar.Text = "Atras";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 367);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.telefonoTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cedulaTxt);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.vpasswordTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "RegistrarUsuario";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vpasswordTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button Cancelar;
    }
}