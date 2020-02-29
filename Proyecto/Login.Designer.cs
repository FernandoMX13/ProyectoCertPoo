namespace Proyecto
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuario = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.Label();
            this.ContrasenaBox = new System.Windows.Forms.TextBox();
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.LoginBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(20, 20);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // Contrasena
            // 
            this.Contrasena.AutoSize = true;
            this.Contrasena.Location = new System.Drawing.Point(20, 55);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(61, 13);
            this.Contrasena.TabIndex = 1;
            this.Contrasena.Text = "Contraseña";
            // 
            // ContrasenaBox
            // 
            this.ContrasenaBox.Location = new System.Drawing.Point(100, 55);
            this.ContrasenaBox.Name = "ContrasenaBox";
            this.ContrasenaBox.PasswordChar = '*';
            this.ContrasenaBox.Size = new System.Drawing.Size(360, 20);
            this.ContrasenaBox.TabIndex = 2;
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Location = new System.Drawing.Point(100, 17);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(360, 20);
            this.UsuarioBox.TabIndex = 3;
            // 
            // LoginBoton
            // 
            this.LoginBoton.Location = new System.Drawing.Point(220, 100);
            this.LoginBoton.Name = "LoginBoton";
            this.LoginBoton.Size = new System.Drawing.Size(75, 23);
            this.LoginBoton.TabIndex = 4;
            this.LoginBoton.Text = "Login";
            this.LoginBoton.UseVisualStyleBackColor = true;
            this.LoginBoton.Click += new System.EventHandler(this.LoginBoton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 136);
            this.Controls.Add(this.LoginBoton);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.ContrasenaBox);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.Usuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 175);
            this.MinimumSize = new System.Drawing.Size(500, 175);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contrasena;
        private System.Windows.Forms.TextBox ContrasenaBox;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.Button LoginBoton;
    }
}

