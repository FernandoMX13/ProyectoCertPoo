using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class AgregarUsuarioMenu : Form
    {
        public AgregarUsuarioMenu()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddUsu_Click(object sender, EventArgs e)
        {
            string paswd;
            string puesto;
            if (NewName.Text == "")
                MessageBox.Show("Debe ingresar un nombre");
            else if (NewPassword.Text == "")
                MessageBox.Show("Debe ingresar una contraseña");
            else if (Comprobacion.Text == "")
                MessageBox.Show("Debe ingresar de nuevo la contraseña");
            else if (Program.Users.ContainsKey(NewName.Text))
                MessageBox.Show("El usuario ya esta registrado.");
            else if (NewPassword.Text != Comprobacion.Text)
            {
                MessageBox.Show("No coinciden las contraseñas vuelva a ingresarlas");
                NewPassword.Text = "";
                Comprobacion.Text = "";
            }
            else
            {
                paswd = Login.getSHA256(NewPassword.Text);
                if (Administrador.Checked)
                    puesto = "administrador";
                else if (Gerente.Checked)
                    puesto = "gerente";
                else
                    puesto = "cajero";
                using (StreamWriter outputFile = new StreamWriter(Program.doc, true))
                {
                    outputFile.Write("{0}|{1}|{2}", NewName.Text, paswd, puesto);
                }
                MessageBox.Show("Usuario agregado");
                NewName.Text = "";
                NewPassword.Text = "";
                Comprobacion.Text = "";
            }
        }

        private void Regreso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión de administrador cerrada.");
            this.Hide();
            this.Close();
        }
    }
}
