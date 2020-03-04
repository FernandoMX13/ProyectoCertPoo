namespace Proyecto
{
    partial class gerenteMenu
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
            this.BienvenidaGerente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalirButton = new System.Windows.Forms.Button();
            this.ReturnLoginButton = new System.Windows.Forms.Button();
            this.DeleteProdButton = new System.Windows.Forms.Button();
            this.AddProdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BienvenidaGerente
            // 
            this.BienvenidaGerente.AutoSize = true;
            this.BienvenidaGerente.Location = new System.Drawing.Point(45, 30);
            this.BienvenidaGerente.Name = "BienvenidaGerente";
            this.BienvenidaGerente.Size = new System.Drawing.Size(162, 13);
            this.BienvenidaGerente.TabIndex = 1;
            this.BienvenidaGerente.Text = "Bienvenido al menu de grenecia.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Qué desea realizar?";
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(18, 207);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(254, 36);
            this.SalirButton.TabIndex = 9;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // ReturnLoginButton
            // 
            this.ReturnLoginButton.Location = new System.Drawing.Point(18, 165);
            this.ReturnLoginButton.Name = "ReturnLoginButton";
            this.ReturnLoginButton.Size = new System.Drawing.Size(254, 36);
            this.ReturnLoginButton.TabIndex = 8;
            this.ReturnLoginButton.Text = "Regresar al Login";
            this.ReturnLoginButton.UseVisualStyleBackColor = true;
            this.ReturnLoginButton.Click += new System.EventHandler(this.ReturnLoginButton_Click);
            // 
            // DeleteProdButton
            // 
            this.DeleteProdButton.Location = new System.Drawing.Point(18, 123);
            this.DeleteProdButton.Name = "DeleteProdButton";
            this.DeleteProdButton.Size = new System.Drawing.Size(254, 36);
            this.DeleteProdButton.TabIndex = 7;
            this.DeleteProdButton.Text = "Eliminar Producto";
            this.DeleteProdButton.UseVisualStyleBackColor = true;
            this.DeleteProdButton.Click += new System.EventHandler(this.DeleteProdButton_Click);
            // 
            // AddProdButton
            // 
            this.AddProdButton.Location = new System.Drawing.Point(18, 81);
            this.AddProdButton.Name = "AddProdButton";
            this.AddProdButton.Size = new System.Drawing.Size(254, 36);
            this.AddProdButton.TabIndex = 6;
            this.AddProdButton.Text = "Agregar Producto";
            this.AddProdButton.UseVisualStyleBackColor = true;
            this.AddProdButton.Click += new System.EventHandler(this.AddProdButton_Click);
            // 
            // gerenteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.ControlBox = false;
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ReturnLoginButton);
            this.Controls.Add(this.DeleteProdButton);
            this.Controls.Add(this.AddProdButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BienvenidaGerente);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "gerenteMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BienvenidaGerente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button ReturnLoginButton;
        private System.Windows.Forms.Button DeleteProdButton;
        private System.Windows.Forms.Button AddProdButton;
    }
}