using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Proyecto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ProductosArchivo prod = new ProductosArchivo();
            Application.Run(new Login());
           
        }
        public static string rutaDoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BecarioMart");
        public static string doc = Path.Combine(rutaDoc, "usu");
        public static string prod = Path.Combine(rutaDoc, "prod");
        public static string ticket = Path.Combine(rutaDoc, "ticket.txt");
        public static string compras = Path.Combine(rutaDoc, "compras.txt");
        public static Dictionary<string, string[]> Users = new Dictionary<string, string[]>();
    }
}
