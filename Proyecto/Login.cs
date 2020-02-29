using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Login : Form
    {
        public static void  actualizaUsers()
        {
            string line;
            string[] Usrpass = new string[3];
            Program.Users.Clear();
            StreamReader file = new StreamReader(Program.doc);
            while ((line = file.ReadLine()) != null)
            {
                Usrpass = line.Split('|');
                string[] test = { Usrpass[1], Usrpass[2] };
                Program.Users.Add(Usrpass[0], test);
            }
            file.Close();
        }
        public static string getSHA256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        public static void CrearUsuarios(string doc)
        {
            using (StreamWriter File = new StreamWriter(doc))
            {
                File.WriteLine("Dialid|de2d51a06c782f54b99a8c899506dd91004136653456fe8494000c9029243b59|gerente");
                File.WriteLine("Mau|5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5|administrador");
                File.WriteLine("Fer|65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5|cajero");
            }
        }
        public Login()
        {
            Program.Users.Clear();
            DirectoryInfo dInfo = new DirectoryInfo(Program.rutaDoc);
            FileInfo passwd = new FileInfo(Program.doc);
            if (!dInfo.Exists)
            {
                dInfo.Create();
            }
            if (!passwd.Exists)
            {
                FileStream fs = passwd.Create();
                fs.Close();
                CrearUsuarios(Program.doc);
            }
            actualizaUsers();
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBoton_Click(object sender, EventArgs e)
        {
            string checkUser = UsuarioBox.Text;
            if (Program.Users.ContainsKey(checkUser))
            {
                string checkPassword = getSHA256(ContrasenaBox.Text);
                string[] pass = Program.Users[checkUser];
                if (pass[0].ToString() == checkPassword)
                {
                    if (pass[1].ToString() == "gerente")
                        MessageBox.Show("Bienvenido Gerente");
                    else if (pass[1].ToString() == "administrador")
                    {
                        MessageBox.Show("Bienvenido Administrador");
                        AdminMenu adminMenu = new AdminMenu();
                        this.Hide();
                        adminMenu.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido Cajero");
                        Principal principal = new Principal();
                        this.Hide();
                        principal.ShowDialog();
                        this.Close();
                    }
                    
                }
                else
                    MessageBox.Show("Contraseña incorrecta.");
            }
            else
                MessageBox.Show("Usuario incorrecto.");

        }
    }
}