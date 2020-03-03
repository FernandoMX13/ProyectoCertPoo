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
    public partial class gerenteMenu : Form
    {
        public gerenteMenu()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void AddProdButton_Click(object sender, EventArgs e)
        {
            AgregarProdMenu Agregar = new AgregarProdMenu();
            this.Hide();
            Agregar.ShowDialog();
            Agregar = null;
            this.Show();
        }

        private void DeleteProdButton_Click(object sender, EventArgs e)
        {
            EliminarProdMenu Eliminar = new EliminarProdMenu();
            this.Hide();
            Eliminar.ShowDialog();
            Eliminar = null;
            this.Show();
        }
    }
}
