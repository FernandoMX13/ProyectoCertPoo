using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class EliminarProdMenu : Form
    {
        public EliminarProdMenu()
        {
            InitializeComponent();
        }

        private void returntolobby_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void EliminarProdMenu_Load(object sender, EventArgs e)
        {
            string[] dat = new string[2];
            AgregarProdMenu.obtenerProd();
            foreach (KeyValuePair<string, string[]> all in AgregarProdMenu.Prods)
            {
                dat = all.Value.ToArray();
                if (dat[0].Length > 20)
                    productosToDeleteList.Items.Add(all.Key + "\t" + dat[0].Substring(0,20) + "\t\t\t\t" + dat[1]);
                else
                    productosToDeleteList.Items.Add(all.Key + "\t" + dat[0] + "\t\t\t\t" + dat[1]);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {/*
            bool borre = false;
            bool advertencia = false;
            string admin = "";
            int tam = AgregarProdMenu.Prods.Count;
            int total = tam;
            List<int> borrame = new List<int>();
            borrame.Clear();
            for (int i = 0; i < tam; i++)
            {
                if (productosToDeleteList.GetItemChecked(i) == true)
                {
                    string probable = productosToDeleteList.Items[i].ToString();
                    string result = Regex.Replace(probable, @"\s+", "|");
                    string[] datosABorrar = result.Split('|');
                    
                        borre = true;
                        if (datosABorrar[1].Contains("administrador"))
                            admins -= 1;
                        Program.Users.Remove(datosABorrar[0]);
                        borrame.Add(i);
                }
            }
            if (advertencia)
                MessageBox.Show("No se elimino a " + admin + ", el sistema necesita al menos un administrador");
            if (borre)
            {
                string[] dat = new string[2];
                borrame.Reverse();
                foreach (int n in borrame)
                    Usuarios.Items.Remove(Usuarios.Items[n]);
                using (StreamWriter outputFile = new StreamWriter(Program.doc))
                {
                    foreach (KeyValuePair<string, string[]> all in Program.Users)
                    {
                        dat = all.Value.ToArray();
                        outputFile.Write("{0}|{1}|{2}\n", all.Key, dat[0], dat[1]);
                    }
                }
                MessageBox.Show("Eliminación de usuarios terminada.");
            }*/
        }

        private void regreso_Click(object sender, EventArgs e)
        {
            Login.actualizaUsers();
            this.Hide();
            this.Close();
        }
    }
}

