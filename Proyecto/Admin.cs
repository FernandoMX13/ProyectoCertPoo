using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto
{
    public partial class AdminMenu : Form
    {
        public static Dictionary<string, string[]> Users = new Dictionary<string, string[]>();
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AgregarUsuarioMenu Agregar = new AgregarUsuarioMenu();
            this.Hide();
            Agregar.ShowDialog();
            /*
            string line;
            string rutaDoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BecarioMart");
            string[] Usrpass = new string[3];
            string doc = Path.Combine(rutaDoc, "usu");
            StreamReader file = new StreamReader(doc);
            while ((line = file.ReadLine()) != null)
            {
                Usrpass = line.Split('|');
                string[] test = { Usrpass[1], Usrpass[2] };
                Users.Add(Usrpass[0], test);
            }*/
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
