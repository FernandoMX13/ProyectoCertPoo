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
    public partial class AdminMenu : Form
    {
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
            Application.Exit();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AgregarUsuarioMenu Agregar = new AgregarUsuarioMenu();
            this.Hide();
            Agregar.ShowDialog();
            Agregar = null;
            this.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            EliminarUsuariosMenu Eliminar = new EliminarUsuariosMenu();
            this.Hide();
            Eliminar.ShowDialog();
            Eliminar = null;
            this.Show();
        }
    }
}
