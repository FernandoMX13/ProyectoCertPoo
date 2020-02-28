namespace Proyecto
{
    partial class AdminMenu
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
            this.BienvenidaAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.ReturnLoginButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BienvenidaAdmin
            // 
            this.BienvenidaAdmin.AutoSize = true;
            this.BienvenidaAdmin.Location = new System.Drawing.Point(45, 30);
            this.BienvenidaAdmin.Name = "BienvenidaAdmin";
            this.BienvenidaAdmin.Size = new System.Drawing.Size(188, 13);
            this.BienvenidaAdmin.TabIndex = 0;
            this.BienvenidaAdmin.Text = "Bienvenido al menu de administración.";
            this.BienvenidaAdmin.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Qué desea realizar?";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(18, 81);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(254, 36);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Agregar Usuario";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(18, 123);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(254, 36);
            this.DeleteUserButton.TabIndex = 3;
            this.DeleteUserButton.Text = "Eliminar Usuario";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // ReturnLoginButton
            // 
            this.ReturnLoginButton.Location = new System.Drawing.Point(18, 165);
            this.ReturnLoginButton.Name = "ReturnLoginButton";
            this.ReturnLoginButton.Size = new System.Drawing.Size(254, 36);
            this.ReturnLoginButton.TabIndex = 4;
            this.ReturnLoginButton.Text = "Regresar al Login";
            this.ReturnLoginButton.UseVisualStyleBackColor = true;
            this.ReturnLoginButton.Click += new System.EventHandler(this.ReturnLoginButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(18, 207);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(254, 36);
            this.SalirButton.TabIndex = 5;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.ControlBox = false;
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ReturnLoginButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BienvenidaAdmin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "AdminMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Administración";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BienvenidaAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button ReturnLoginButton;
        private System.Windows.Forms.Button SalirButton;
    }
}