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
    public partial class AgregarProdMenu : Form
    {
        public static Dictionary<string, string[]> Prods = new Dictionary<string, string[]>();
        public static bool veriProd(string prod) {
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
        public AgregarProdMenu()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double precio;
            obtenerProd();
            if (!uint.TryParse(IDBox.Text, out _) || IDBox.Text == "")
            {
                MessageBox.Show("No se ha ingresado una ID valida, debe de ser un numero entero positivo. Ingrese una ID valida");
                IDBox.Text = "";
            }
            else if (Prods.ContainsKey(IDBox.Text))
            {
                MessageBox.Show("La ID ya existe, Ingrese otra");
                IDBox.Text = "";
            }
            else if (descriptionBox.Text == "")
            {
                MessageBox.Show("No ingreso una descipcion");
            }
            else if (veriProd(descriptionBox.Text))
            {
                MessageBox.Show("Ya existe un producto con esa descripcion");
                descriptionBox.Text = "";
            }
            else if (!double.TryParse(priceBox.Text, out precio) || IDBox.Text == "")
            {
                MessageBox.Show("No se ha ingresado in precio valido");
                priceBox.Text = "";
            }
            else 
            {
                string[] dat = {descriptionBox.Text, precio.ToString("N2") };
                using (StreamWriter outputFile = new StreamWriter(Program.prod, true))
                {
                    outputFile.Write("{0}|{1}|{2}\n", IDBox.Text, descriptionBox.Text, precio.ToString("N2"));
                }
                MessageBox.Show("Se agrego el producto");
                IDBox.Text = "";
                descriptionBox.Text = "";
                priceBox.Text = "";
            }
        }
    }
}
