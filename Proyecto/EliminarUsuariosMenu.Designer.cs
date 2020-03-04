namespace Proyecto
{
    partial class EliminarUsuariosMenu
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
            this.components = new System.ComponentModel.Container();
            this.Usuarios = new System.Windows.Forms.CheckedListBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.regreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuarios
            // 
            this.Usuarios.CheckOnClick = true;
            this.Usuarios.FormattingEnabled = true;
            this.Usuarios.HorizontalScrollbar = true;
            this.Usuarios.Location = new System.Drawing.Point(8, 60);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(431, 139);
            this.Usuarios.TabIndex = 0;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Proyecto.Program);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione que usuarios desea eliminar:";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(184, 205);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Eliminar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // regreso
            // 
            this.regreso.Location = new System.Drawing.Point(184, 236);
            this.regreso.Name = "regreso";
            this.regreso.Size = new System.Drawing.Size(75, 23);
            this.regreso.TabIndex = 3;
            this.regreso.Text = "Regresar";
            this.regreso.UseVisualStyleBackColor = true;
            this.regreso.Click += new System.EventHandler(this.regreso_Click);
            // 
            // EliminarUsuariosMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(451, 271);
            this.ControlBox = false;
            this.Controls.Add(this.regreso);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuarios);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarUsuariosMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Usuarios";
            this.Load += new System.EventHandler(this.EliminarUsuariosMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.CheckedListBox Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button regreso;
    }
}