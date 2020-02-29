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
            Application.Run(new Login());
            ProductosArchivo prod = new ProductosArchivo();
            //
        }
        public static string rutaDoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BecarioMart");
        public static string doc = Path.Combine(rutaDoc, "usu");
        public static string prod = Path.Combine(rutaDoc, "prod");
        public static Dictionary<string, string[]> Users = new Dictionary<string, string[]>();
    }
}
