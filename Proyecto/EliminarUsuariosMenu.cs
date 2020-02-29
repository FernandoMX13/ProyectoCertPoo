using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class EliminarUsuariosMenu : Form
    {
        public static Dictionary<string, string> UsersShow = new Dictionary<string, string>();
        public static int admins;
        public EliminarUsuariosMenu()
        {
            InitializeComponent();  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void EliminarUsuariosMenu_Load(object sender, EventArgs e)
        {
            string[] dat = new string[2];
            Login.actualizaUsers();
            admins = 0;
            foreach (KeyValuePair<string, string[]> all in Program.Users)
            {
                dat = all.Value.ToArray();
                Usuarios.Items.Add(all.Key+"\t\t\t"+dat[1]);
                if (dat[1] == "administrador")
                    admins+=1;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bool borre = false;
            bool advertencia = false;
            string admin = "";
            int tam = Program.Users.Count;
            List<int> borrame = new List<int>();
            borrame.Clear();
            for (int i = 0; i < tam; i++)
            {
                if (Usuarios.GetItemChecked(i) == true) 
                {
                    string probable = Usuarios.Items[i].ToString();
                    string result = Regex.Replace(probable, @"\s+", "|");
                    string [] datosABorrar = result.Split('|');
                    if (datosABorrar[1].Contains("administrador") && admins == 1)
                    {
                        advertencia = true;
                        admin = datosABorrar[0];
                    }
                    else
                    {
                        borre = true;
                        if (datosABorrar[1].Contains("administrador"))
                            admins -= 1;
                        Program.Users.Remove(datosABorrar[0]);
                        borrame.Add(i);
                    }
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
            }
        }

        private void regreso_Click(object sender, EventArgs e)
        {
            Login.actualizaUsers();
            this.Hide();
            this.Close();
        }
    }
}
