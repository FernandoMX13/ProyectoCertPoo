using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Principal : Form
    {
        public static Dictionary<string, string[]> Prods = new Dictionary<string, string[]>();  //Lista completa de productos
        public static Dictionary<string, int> ticket = new Dictionary<string, int>();   //Diccionario que almacena idProd y cantidad de productos comprados
        public static double total = 0;     //Variable que acumule el total a pagar
        public static string idProd = "";        //Variable que lee el id para guardarlo como llave en el diccionario ticket
        /*public static List<string> ticketProductos = new List<string>();
        public static List<string> ticketCantidad = new List<string>();
        public static List<string> ticketPrecio = new List<string>();*/
        public static bool veriProd(string prod)
        {
            string[] dat = new string[2];
            foreach (KeyValuePair<string, string[]> all in Prods)
            {
                dat = all.Value.ToArray();
                if (dat[0] == prod)
                    return true;
            }
            return false;
        }
        public static void obtenerProd()
        {
            string line;
            string[] Prodpass = new string[3];
            Prods.Clear();
            StreamReader file = new StreamReader(Program.prod);
            while ((line = file.ReadLine()) != null)
            {
                Prodpass = line.Split('|');
                string[] test = { Prodpass[1], Prodpass[2] };
                Prods.Add(Prodpass[0], test);
            }
            file.Close();
        }
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void salirMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obtenerProd();
            if (!Prods.ContainsKey(CodigoProdBox.Text))
            {
                MessageBox.Show("No existe ese producto.");
                CodigoProdBox.Text = "";
            }
            else
            {
                labelProductoMostrado.Text = Prods[CodigoProdBox.Text][0].ToString();
                labelPrecioMostrado.Text = "$" + Prods[CodigoProdBox.Text][1].ToString();
                idProd = CodigoProdBox.Text;
            }
        }

        private void AgregarAlCarro_Click(object sender, EventArgs e)
        {
            try
            {
                //El diccionario "ticket" contiene todos los productos y cantidades
                if (ticket.ContainsKey(idProd))
                    ticket[idProd] += Convert.ToInt32(CantidadNumero.Value);
                else
                    ticket.Add(idProd, Convert.ToInt32(CantidadNumero.Value));
                //Suma del total
                total += Convert.ToDouble(labelPrecioMostrado.Text.Substring(1)) * Convert.ToDouble(CantidadNumero.Value);
                PagarLabel.Text = "$" + total.ToString();
                /*//Se agregan los productos a las listas
                ticketProductos.Add(labelProductoMostrado.Text);
                ticketCantidad.Add(CantidadNumero.Value.ToString());
                ticketPrecio.Add(labelPrecioMostrado.Text);
                 */
                //Se agregan los productos a la pantalla
                listboxProductosLista.Items.Add(labelProductoMostrado.Text);
                listboxCantidadLista.Items.Add(CantidadNumero.Value.ToString());
                listboxPrecioLista.Items.Add(labelPrecioMostrado.Text);
                //Limpieza de label
                labelProductoMostrado.Text = "";
                labelPrecioMostrado.Text = "";
                CodigoProdBox.Text = "";
                CantidadNumero.Value = 1;
                idProd = "";
            }
            catch
            {
                MessageBox.Show("Ingresa un id de producto y presiona OK.");
            }
        }

        private void EliminarProdBoton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ticket.ContainsKey(idProd))
                {
                    MessageBox.Show("No existe ese producto en el ticket.");
                    labelProductoMostrado.Text = "";
                    labelPrecioMostrado.Text = "";
                    CodigoProdBox.Text = "";
                    CantidadNumero.Value = 1;
                    idProd = "";
                }
                else
                {
                    if (ticket[idProd] > 0)
                    {
                        //Resta al total
                        total -= Convert.ToDouble(labelPrecioMostrado.Text.Substring(1));
                        PagarLabel.Text = "$" + total.ToString();
                        //Agrega al ticket la resta del producto
                        listboxProductosLista.Items.Add("* - " + labelProductoMostrado.Text);
                        listboxCantidadLista.Items.Add("- 1");
                        listboxPrecioLista.Items.Add("- " + labelPrecioMostrado.Text);
                        //Se limpian los label
                        labelProductoMostrado.Text = "";
                        labelPrecioMostrado.Text = "";
                        CodigoProdBox.Text = "";
                        CantidadNumero.Value = 1;
                        //Quitamos una cantidad
                        ticket[idProd] -= 1;
                        //Si ahora el valor es cero, lo quitamos del diccionario
                        if (ticket[idProd] == 0)
                            ticket.Remove(idProd);
                        idProd = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingresa un id de producto y presiona OK.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("¿Está seguro de que desea cancelar la compra?", "Cancelar compra", MessageBoxButtons.YesNo);
            if (cancelar == DialogResult.Yes)
                limpiar_todo();
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            try
            {
                double pago = Convert.ToDouble(textBoxPago.Text);
                if (ticket.Count > 0)
                    if (pago >= total)
                    {
                        MessageBox.Show("Su cambio: $" + (pago - total).ToString() + " \n¡Gracias por su compra! ¡Vuelva pronto!");
                        archivo_ticket();
                        archivo_compras();
                        limpiar_todo();
                    }
                    else
                        MessageBox.Show("Dinero insuficiente para pagar la compra. Favor de aumentar el pago o cancelar la compra.");
                else
                {
                    MessageBox.Show("No hay productos agregados a la cuenta");
                    textBoxPago.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Debes ingresar una cantidad numérica en el campo de pago");
                textBoxPago.Text = "";
            }
        }

        private void limpiar_todo()
        {
            //Limpiamos todo
            listboxProductosLista.Items.Clear();
            listboxCantidadLista.Items.Clear();
            listboxPrecioLista.Items.Clear();
            labelProductoMostrado.Text = "";
            labelPrecioMostrado.Text = "";
            CodigoProdBox.Text = "";
            textBoxPago.Text = "";
            ticket.Clear();
            total = 0;
            PagarLabel.Text = "$" + total.ToString();
            CantidadNumero.Value = 1;
        }

        private void archivo_ticket()
        {
            FileInfo info_t = new FileInfo(Program.ticket);
            DirectoryInfo tInfo = new DirectoryInfo(Program.rutaDoc);
            if (!tInfo.Exists)
            {
                tInfo.Create();
            }
            FileStream fs = info_t.Create();
            fs.Close();
            using (StreamWriter File = new StreamWriter(Program.ticket))
            {
                File.WriteLine(DateTime.Now.ToString());
                File.WriteLine("ID Producto | Nombre del Producto | Precio del producto | Cantidad");
                foreach (KeyValuePair<string, int> prod in ticket)
                {
                    File.WriteLine("{0} | {1} | {2} | {3}",
                        prod.Key, Prods[prod.Key][0].ToString(), "$" + Prods[prod.Key][1].ToString(), prod.Value);

                }
                File.WriteLine("Total: ${0}", total);
            }
        }

        private void archivo_compras()
        {
            FileInfo compras = new FileInfo(Program.compras);
            DirectoryInfo cInfo = new DirectoryInfo(Program.rutaDoc);
            if (!cInfo.Exists)
            {
                cInfo.Create();
            }
            if (!compras.Exists)
            {
                FileStream fs = compras.Create();
                fs.Close();
            }
            using (StreamWriter com= File.AppendText(Program.compras))
            {
                com.WriteLine("Compra registrada");
                com.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
