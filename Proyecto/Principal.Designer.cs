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
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.BuscarProdLabel = new System.Windows.Forms.Label();
            this.CodigoProdBox = new System.Windows.Forms.TextBox();
            this.AgregarAlCarro = new System.Windows.Forms.Button();
            this.EliminarProdBoton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PagarLabel = new System.Windows.Forms.Label();
            this.labelProductoCabecera = new System.Windows.Forms.Label();
            this.labelCantidadCabecera = new System.Windows.Forms.Label();
            this.labelPrecioCabecera = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPago = new System.Windows.Forms.Label();
            this.textBoxPago = new System.Windows.Forms.TextBox();
            this.labelCambio = new System.Windows.Forms.Label();
            this.labelCambioDevuelto = new System.Windows.Forms.Label();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.labelProductoMostrado = new System.Windows.Forms.Label();
            this.labelPrecioMostrado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CantidadNumero = new System.Windows.Forms.NumericUpDown();
            this.listboxProductosLista = new System.Windows.Forms.ListBox();
            this.listboxCantidadLista = new System.Windows.Forms.ListBox();
            this.listboxPrecioLista = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.CodigoProdBox.Size = new System.Drawing.Size(121, 30);
            this.CodigoProdBox.TabIndex = 6;
            // 
            // AgregarAlCarro
            // 
            this.AgregarAlCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarAlCarro.Location = new System.Drawing.Point(109, 218);
            this.AgregarAlCarro.Name = "AgregarAlCarro";
            this.AgregarAlCarro.Size = new System.Drawing.Size(96, 33);
            this.AgregarAlCarro.TabIndex = 7;
            this.AgregarAlCarro.Text = "Agregar";
            this.AgregarAlCarro.UseVisualStyleBackColor = true;
            this.AgregarAlCarro.Click += new System.EventHandler(this.AgregarAlCarro_Click);
            // 
            // EliminarProdBoton
            // 
            this.EliminarProdBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarProdBoton.Location = new System.Drawing.Point(344, 218);
            this.EliminarProdBoton.Name = "EliminarProdBoton";
            this.EliminarProdBoton.Size = new System.Drawing.Size(96, 33);
            this.EliminarProdBoton.TabIndex = 8;
            this.EliminarProdBoton.Text = "Eliminar";
            this.EliminarProdBoton.UseVisualStyleBackColor = true;
            this.EliminarProdBoton.Click += new System.EventHandler(this.EliminarProdBoton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(978, 401);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(62, 25);
            this.TotalLabel.TabIndex = 14;
            this.TotalLabel.Text = "Total:";
            // 
            // PagarLabel
            // 
            this.PagarLabel.AutoSize = true;
            this.PagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagarLabel.Location = new System.Drawing.Point(1058, 401);
            this.PagarLabel.Name = "PagarLabel";
            this.PagarLabel.Size = new System.Drawing.Size(61, 25);
            this.PagarLabel.TabIndex = 15;
            this.PagarLabel.Text = "$0.00";
            // 
            // labelProductoCabecera
            // 
            this.labelProductoCabecera.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProductoCabecera.BackColor = System.Drawing.SystemColors.Window;
            this.labelProductoCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProductoCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductoCabecera.Location = new System.Drawing.Point(597, 33);
            this.labelProductoCabecera.Name = "labelProductoCabecera";
            this.labelProductoCabecera.Size = new System.Drawing.Size(387, 29);
            this.labelProductoCabecera.TabIndex = 16;
            this.labelProductoCabecera.Text = "Producto";
            this.labelProductoCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCantidadCabecera
            // 
            this.labelCantidadCabecera.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCantidadCabecera.BackColor = System.Drawing.SystemColors.Window;
            this.labelCantidadCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCantidadCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadCabecera.Location = new System.Drawing.Point(983, 33);
            this.labelCantidadCabecera.Name = "labelCantidadCabecera";
            this.labelCantidadCabecera.Size = new System.Drawing.Size(81, 29);
            this.labelCantidadCabecera.TabIndex = 17;
            this.labelCantidadCabecera.Text = "Cantidad";
            this.labelCantidadCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrecioCabecera
            // 
            this.labelPrecioCabecera.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrecioCabecera.BackColor = System.Drawing.SystemColors.Window;
            this.labelPrecioCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrecioCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioCabecera.Location = new System.Drawing.Point(1063, 33);
            this.labelPrecioCabecera.Name = "labelPrecioCabecera";
            this.labelPrecioCabecera.Size = new System.Drawing.Size(106, 29);
            this.labelPrecioCabecera.TabIndex = 18;
            this.labelPrecioCabecera.Text = "Precio";
            this.labelPrecioCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancelar compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.Location = new System.Drawing.Point(21, 343);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(64, 25);
            this.labelPago.TabIndex = 24;
            this.labelPago.Text = "Pago:";
            // 
            // textBoxPago
            // 
            this.textBoxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPago.Location = new System.Drawing.Point(117, 343);
            this.textBoxPago.Name = "textBoxPago";
            this.textBoxPago.Size = new System.Drawing.Size(136, 30);
            this.textBoxPago.TabIndex = 25;
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.Location = new System.Drawing.Point(21, 394);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(86, 25);
            this.labelCambio.TabIndex = 26;
            this.labelCambio.Text = "Cambio:";
            // 
            // labelCambioDevuelto
            // 
            this.labelCambioDevuelto.AutoSize = true;
            this.labelCambioDevuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambioDevuelto.Location = new System.Drawing.Point(167, 394);
            this.labelCambioDevuelto.Name = "labelCambioDevuelto";
            this.labelCambioDevuelto.Size = new System.Drawing.Size(0, 25);
            this.labelCambioDevuelto.TabIndex = 27;
            // 
            // buttonPagar
            // 
            this.buttonPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.Location = new System.Drawing.Point(295, 339);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(96, 33);
            this.buttonPagar.TabIndex = 28;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // labelProductoMostrado
            // 
            this.labelProductoMostrado.AutoSize = true;
            this.labelProductoMostrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductoMostrado.Location = new System.Drawing.Point(123, 78);
            this.labelProductoMostrado.Name = "labelProductoMostrado";
            this.labelProductoMostrado.Size = new System.Drawing.Size(0, 25);
            this.labelProductoMostrado.TabIndex = 30;
            // 
            // labelPrecioMostrado
            // 
            this.labelPrecioMostrado.AutoSize = true;
            this.labelPrecioMostrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioMostrado.Location = new System.Drawing.Point(123, 118);
            this.labelPrecioMostrado.Name = "labelPrecioMostrado";
            this.labelPrecioMostrado.Size = new System.Drawing.Size(0, 25);
            this.labelPrecioMostrado.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(344, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 33);
            this.button2.TabIndex = 32;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CantidadNumero
            // 
            this.CantidadNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadNumero.Location = new System.Drawing.Point(212, 152);
            this.CantidadNumero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CantidadNumero.Name = "CantidadNumero";
            this.CantidadNumero.Size = new System.Drawing.Size(70, 30);
            this.CantidadNumero.TabIndex = 33;
            this.CantidadNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listboxProductosLista
            // 
            this.listboxProductosLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxProductosLista.FormattingEnabled = true;
            this.listboxProductosLista.ItemHeight = 20;
            this.listboxProductosLista.Location = new System.Drawing.Point(597, 61);
            this.listboxProductosLista.Name = "listboxProductosLista";
            this.listboxProductosLista.Size = new System.Drawing.Size(387, 324);
            this.listboxProductosLista.TabIndex = 34;
            // 
            // listboxCantidadLista
            // 
            this.listboxCantidadLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCantidadLista.FormattingEnabled = true;
            this.listboxCantidadLista.ItemHeight = 20;
            this.listboxCantidadLista.Location = new System.Drawing.Point(983, 61);
            this.listboxCantidadLista.Name = "listboxCantidadLista";
            this.listboxCantidadLista.Size = new System.Drawing.Size(81, 324);
            this.listboxCantidadLista.TabIndex = 35;
            // 
            // listboxPrecioLista
            // 
            this.listboxPrecioLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxPrecioLista.FormattingEnabled = true;
            this.listboxPrecioLista.ItemHeight = 20;
            this.listboxPrecioLista.Location = new System.Drawing.Point(1063, 61);
            this.listboxPrecioLista.Name = "listboxPrecioLista";
            this.listboxPrecioLista.Size = new System.Drawing.Size(106, 324);
            this.listboxPrecioLista.TabIndex = 36;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.listboxPrecioLista);
            this.Controls.Add(this.listboxCantidadLista);
            this.Controls.Add(this.listboxProductosLista);
            this.Controls.Add(this.CantidadNumero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelPrecioMostrado);
            this.Controls.Add(this.labelProductoMostrado);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.labelCambioDevuelto);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.textBoxPago);
            this.Controls.Add(this.labelPago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPrecioCabecera);
            this.Controls.Add(this.labelCantidadCabecera);
            this.Controls.Add(this.labelProductoCabecera);
            this.Controls.Add(this.PagarLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.EliminarProdBoton);
            this.Controls.Add(this.AgregarAlCarro);
            this.Controls.Add(this.CodigoProdBox);
            this.Controls.Add(this.BuscarProdLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label BuscarProdLabel;
        private System.Windows.Forms.TextBox CodigoProdBox;
        private System.Windows.Forms.Button AgregarAlCarro;
        private System.Windows.Forms.Button EliminarProdBoton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PagarLabel;
        private System.Windows.Forms.Label labelProductoCabecera;
        private System.Windows.Forms.Label labelCantidadCabecera;
        private System.Windows.Forms.Label labelPrecioCabecera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.TextBox textBoxPago;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Label labelCambioDevuelto;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.Label labelProductoMostrado;
        private System.Windows.Forms.Label labelPrecioMostrado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown CantidadNumero;
        private System.Windows.Forms.ListBox listboxProductosLista;
        private System.Windows.Forms.ListBox listboxCantidadLista;
        private System.Windows.Forms.ListBox listboxPrecioLista;
    }
}