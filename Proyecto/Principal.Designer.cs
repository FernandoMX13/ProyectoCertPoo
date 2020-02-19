namespace Proyecto
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadNumero = new System.Windows.Forms.DomainUpDown();
            this.BuscarProdLabel = new System.Windows.Forms.Label();
            this.CodigoProdBox = new System.Windows.Forms.TextBox();
            this.AgregarAlCarro = new System.Windows.Forms.Button();
            this.EliminarProdBoton = new System.Windows.Forms.Button();
            this.AgregarProd = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PagarLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarMenu,
            this.salirMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarMenu
            // 
            this.buscarMenu.Name = "buscarMenu";
            this.buscarMenu.Size = new System.Drawing.Size(54, 20);
            this.buscarMenu.Text = "Buscar";
            // 
            // salirMenu
            // 
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Size = new System.Drawing.Size(41, 20);
            this.salirMenu.Text = "Salir";
            this.salirMenu.Click += new System.EventHandler(this.salirMenu_Click);
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.Location = new System.Drawing.Point(12, 78);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(96, 25);
            this.ProductoLabel.TabIndex = 1;
            this.ProductoLabel.Text = "Producto:";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(12, 118);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(73, 25);
            this.PrecioLabel.TabIndex = 2;
            this.PrecioLabel.Text = "Precio:";
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(12, 157);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(97, 25);
            this.CantidadLabel.TabIndex = 3;
            this.CantidadLabel.Text = "Cantidad:";
            // 
            // CantidadNumero
            // 
            this.CantidadNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadNumero.Location = new System.Drawing.Point(172, 155);
            this.CantidadNumero.Name = "CantidadNumero";
            this.CantidadNumero.Size = new System.Drawing.Size(59, 30);
            this.CantidadNumero.TabIndex = 4;
            this.CantidadNumero.Text = "1";
            // 
            // BuscarProdLabel
            // 
            this.BuscarProdLabel.AutoSize = true;
            this.BuscarProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProdLabel.Location = new System.Drawing.Point(12, 34);
            this.BuscarProdLabel.Name = "BuscarProdLabel";
            this.BuscarProdLabel.Size = new System.Drawing.Size(193, 25);
            this.BuscarProdLabel.TabIndex = 5;
            this.BuscarProdLabel.Text = "Código del producto:";
            // 
            // CodigoProdBox
            // 
            this.CodigoProdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProdBox.Location = new System.Drawing.Point(211, 31);
            this.CodigoProdBox.Name = "CodigoProdBox";
            this.CodigoProdBox.Size = new System.Drawing.Size(159, 30);
            this.CodigoProdBox.TabIndex = 6;
            // 
            // AgregarAlCarro
            // 
            this.AgregarAlCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarAlCarro.Location = new System.Drawing.Point(17, 218);
            this.AgregarAlCarro.Name = "AgregarAlCarro";
            this.AgregarAlCarro.Size = new System.Drawing.Size(96, 33);
            this.AgregarAlCarro.TabIndex = 7;
            this.AgregarAlCarro.Text = "Agregar";
            this.AgregarAlCarro.UseVisualStyleBackColor = true;
            // 
            // EliminarProdBoton
            // 
            this.EliminarProdBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarProdBoton.Location = new System.Drawing.Point(172, 218);
            this.EliminarProdBoton.Name = "EliminarProdBoton";
            this.EliminarProdBoton.Size = new System.Drawing.Size(96, 33);
            this.EliminarProdBoton.TabIndex = 8;
            this.EliminarProdBoton.Text = "Eliminar";
            this.EliminarProdBoton.UseVisualStyleBackColor = true;
            // 
            // AgregarProd
            // 
            this.AgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProd.Location = new System.Drawing.Point(403, 31);
            this.AgregarProd.Multiline = true;
            this.AgregarProd.Name = "AgregarProd";
            this.AgregarProd.Size = new System.Drawing.Size(385, 298);
            this.AgregarProd.TabIndex = 13;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(571, 342);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(62, 25);
            this.TotalLabel.TabIndex = 14;
            this.TotalLabel.Text = "Total:";
            // 
            // PagarLabel
            // 
            this.PagarLabel.AutoSize = true;
            this.PagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagarLabel.Location = new System.Drawing.Point(672, 342);
            this.PagarLabel.Name = "PagarLabel";
            this.PagarLabel.Size = new System.Drawing.Size(61, 25);
            this.PagarLabel.TabIndex = 15;
            this.PagarLabel.Text = "$0.00";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PagarLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.AgregarProd);
            this.Controls.Add(this.EliminarProdBoton);
            this.Controls.Add(this.AgregarAlCarro);
            this.Controls.Add(this.CodigoProdBox);
            this.Controls.Add(this.BuscarProdLabel);
            this.Controls.Add(this.CantidadNumero);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "BecarioMart 2.0";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarMenu;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.DomainUpDown CantidadNumero;
        private System.Windows.Forms.Label BuscarProdLabel;
        private System.Windows.Forms.TextBox CodigoProdBox;
        private System.Windows.Forms.Button AgregarAlCarro;
        private System.Windows.Forms.Button EliminarProdBoton;
        private System.Windows.Forms.TextBox AgregarProd;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PagarLabel;
    }
}