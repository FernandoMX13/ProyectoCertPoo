﻿using System;
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
        public static Dictionary<string, string> Users = new Dictionary<string, string>();
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
                File.WriteLine("Dialid|de2d51a06c782f54b99a8c899506dd91004136653456fe8494000c9029243b59");
                File.WriteLine("Mau|5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5");
                File.WriteLine("Fer|65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5");
            }
        }
        public Login()
        {
            string line;
            string rutaDoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BecarioMart");
            string[] Usrpass = new string[2];
            string doc = Path.Combine(rutaDoc, "usu");
            DirectoryInfo dInfo = new DirectoryInfo(rutaDoc);
            FileInfo passwd = new FileInfo(doc);
            if (!dInfo.Exists)
            {
                dInfo.Create();
            }
            if (!passwd.Exists)
            {
                FileStream fs = passwd.Create();
                fs.Close();
                CrearUsuarios(doc);
            }
            StreamReader file = new StreamReader(doc);
            while ((line = file.ReadLine()) != null)
            {
                Usrpass = line.Split('|');
                Users.Add(Usrpass[0], Usrpass[1]);
            }
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBoton_Click(object sender, EventArgs e)
        {
            string checkUser = UsuarioBox.Text;
            if (Users.ContainsKey(checkUser)) 
            {
                string checkPassword = getSHA256(ContrasenaBox.Text);
                if (Users[checkUser] == checkPassword)
                {
                    MessageBox.Show("Acceso correcto.");
                    Principal principal = new Principal();
                    this.Hide();
                    principal.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Contraseña incorrecta.");
            }
            else
                MessageBox.Show("Usuario incorrecto.");

        }
    }
}
