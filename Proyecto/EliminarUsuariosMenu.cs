using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            foreach (KeyValuePair<string, string[]> all in Program.Users)
            {
                dat = all.Value.ToArray();
                Usuarios.Items.Add(all.Key+"-"+dat[1]);
                if (dat[1] == "administrador")
                    admins++;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.Users.Count; i++)
            {
                if (Usuarios.GetItemChecked(i) == true) 
                {
                    string probableDelete = Usuarios.Items[i].ToString();
                    if (probableDelete.Contains("administrador") && admins == 1)
                        MessageBox.Show("No se eliminaron todos los usuarios se necesita al menos un administrador")
                    else

                }
            }
        }
    }
}
