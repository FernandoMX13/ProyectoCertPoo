﻿namespace Proyecto
{
    partial class EliminarProdMenu
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
            this.productosToDeleteList = new System.Windows.Forms.CheckedListBox();
            this.delete = new System.Windows.Forms.Button();
            this.returntolobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoga que productos desea eliminar.";
            // 
            // productosToDeleteList
            // 
            this.productosToDeleteList.FormattingEnabled = true;
            this.productosToDeleteList.Location = new System.Drawing.Point(8, 60);
            this.productosToDeleteList.Name = "productosToDeleteList";
            this.productosToDeleteList.Size = new System.Drawing.Size(431, 139);
            this.productosToDeleteList.TabIndex = 1;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(184, 205);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // returntolobby
            // 
            this.returntolobby.Location = new System.Drawing.Point(184, 236);
            this.returntolobby.Name = "returntolobby";
            this.returntolobby.Size = new System.Drawing.Size(75, 23);
            this.returntolobby.TabIndex = 3;
            this.returntolobby.Text = "Regresar";
            this.returntolobby.UseVisualStyleBackColor = true;
            this.returntolobby.Click += new System.EventHandler(this.returntolobby_Click);
            // 
            // EliminarProdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 271);
            this.ControlBox = false;
            this.Controls.Add(this.returntolobby);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.productosToDeleteList);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarProdMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Productos";
            this.Load += new System.EventHandler(this.EliminarProdMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox productosToDeleteList;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button returntolobby;
    }
}