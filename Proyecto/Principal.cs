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
        public static Dictionary<string, string[]> Prods = new Dictionary<string, string[]>();
        public static List<string> ticketProductos = new List<string>();
        public static List<string> ticketCantidad = new List<string>();
        public static List<string> ticketPrecio = new List<string>();
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
            }
        }

        private void AgregarAlCarro_Click(object sender, EventArgs e)
        {
            String productos = "";
            String precios = "";
            String cantidad = "";
            ticketProductos.Add(labelProductoMostrado.Text);
            ticketCantidad.Add(CantidadNumero.Value.ToString());
            ticketPrecio.Add(labelPrecioMostrado.Text);
            for(int i = 0; i < ticketProductos.Count(); i++)
            {
                productos += ticketProductos[i] + "\n";
                cantidad += ticketCantidad[i] + "\n";
                precios += ticketPrecio[i] + "\n";
            }
            labelProductosLista.Text = productos;
            labelCantidadLista.Text = cantidad;
            labelPrecioLista.Text = precios;
        }
    }
}
