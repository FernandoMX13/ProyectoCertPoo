namespace Proyecto
{
    partial class AgregarUsuarioMenu
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
            this.NombreUsuAdd = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.NewPassText = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.Comprobacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Administrador = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Gerente = new System.Windows.Forms.RadioButton();
            this.Cajero = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // NombreUsuAdd
            // 
            this.NombreUsuAdd.AutoSize = true;
            this.NombreUsuAdd.Location = new System.Drawing.Point(30, 20);
            this.NombreUsuAdd.Name = "NombreUsuAdd";
            this.NombreUsuAdd.Size = new System.Drawing.Size(173, 13);
            this.NombreUsuAdd.TabIndex = 0;
            this.NombreUsuAdd.Text = "Ingrese Nombre del Nuevo Usuario";
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(30, 40);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(220, 20);
            this.NewName.TabIndex = 1;
            // 
            // NewPassText
            // 
            this.NewPassText.AutoSize = true;
            this.NewPassText.Location = new System.Drawing.Point(30, 70);
            this.NewPassText.Name = "NewPassText";
            this.NewPassText.Size = new System.Drawing.Size(99, 13);
            this.NewPassText.TabIndex = 2;
            this.NewPassText.Text = "Ingrese Contraseña";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(30, 90);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(220, 20);
            this.NewPassword.TabIndex = 3;
            this.NewPassword.UseSystemPasswordChar = true;
            // 
            // Comprobacion
            // 
            this.Comprobacion.Location = new System.Drawing.Point(30, 139);
            this.Comprobacion.Name = "Comprobacion";
            this.Comprobacion.PasswordChar = '*';
            this.Comprobacion.Size = new System.Drawing.Size(220, 20);
            this.Comprobacion.TabIndex = 5;
            this.Comprobacion.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese de nuevo la Contraseña";
            // 
            // Administrador
            // 
            this.Administrador.AutoSize = true;
            this.Administrador.Location = new System.Drawing.Point(30, 195);
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(88, 17);
            this.Administrador.TabIndex = 6;
            this.Administrador.Text = "Administrador";
            this.Administrador.UseVisualStyleBackColor = true;
            this.Administrador.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese de nuevo la Contraseña";
            // 
            // Gerente
            // 
            this.Gerente.AutoSize = true;
            this.Gerente.Location = new System.Drawing.Point(30, 220);
            this.Gerente.Name = "Gerente";
            this.Gerente.Size = new System.Drawing.Size(63, 17);
            this.Gerente.TabIndex = 8;
            this.Gerente.Text = "Gerente";
            this.Gerente.UseVisualStyleBackColor = true;
            // 
            // Cajero
            // 
            this.Cajero.AutoSize = true;
            this.Cajero.Checked = true;
            this.Cajero.Location = new System.Drawing.Point(30, 245);
            this.Cajero.Name = "Cajero";
            this.Cajero.Size = new System.Drawing.Size(55, 17);
            this.Cajero.TabIndex = 9;
            this.Cajero.TabStop = true;
            this.Cajero.Text = "Cajero";
            this.Cajero.UseVisualStyleBackColor = true;
            // 
            // AgregarUsuarioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.ControlBox = false;
            this.Controls.Add(this.Cajero);
            this.Controls.Add(this.Gerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Administrador);
            this.Controls.Add(this.Comprobacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewPassText);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.NombreUsuAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "AgregarUsuarioMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuarioMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreUsuAdd;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Label NewPassText;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox Comprobacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Administrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Gerente;
        private System.Windows.Forms.RadioButton Cajero;
    }
}