using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    //Clase que contiene el método para mandar la información de todos los productos a un archivo
    class ProductosArchivo
    {
        public ProductosArchivo()
        {
            FileInfo productos = new FileInfo(Program.prod);
            DirectoryInfo pInfo = new DirectoryInfo(Program.rutaDoc);
            if (!pInfo.Exists)
            {
                pInfo.Create();
            }
            if (!productos.Exists)
            {
                FileStream fs = productos.Create();
                fs.Close();
                AgregarArchivo(Program.prod);
            }
        }
        public static void AgregarArchivo(string ar)
        {
            using (StreamWriter File = new StreamWriter(ar))
            {
                File.WriteLine("01|Papas Sabritas Adobadas 300g|15.00");
                File.WriteLine("02|Frituras Cheetos Poffets 300g|14.00");
                File.WriteLine("03|Coca Cola 1lt|15.00");
                File.WriteLine("04|Agua Bonafon 1lt|12.00");
                File.WriteLine("05|Jabón Zote 500g|20.00");
                File.WriteLine("06|Detergente Ace 1lt|40.00");
                File.WriteLine("07|Paquete salchichas Alpino pavo 1kg|80.00");
                File.WriteLine("08|Galletas Oreo 4 paq|43.00");
                File.WriteLine("09|Atun Tuni|23.00");
                File.WriteLine("10|Jabon Coporal Zets|20.00");
                File.WriteLine("11|Takis Fuego 450g|25.00");
                File.WriteLine("12|Doritos Nacho 300g|17.00");
                File.WriteLine("13|Sprite 3 lt|27.00");
                File.WriteLine("14|Fanta 2.5 lt|23.00");
                File.WriteLine("15|Pepsi 3 lt|25.00");
                File.WriteLine("16|Surtido Rico|33.00");
                File.WriteLine("17|Galletas Emperador|35.00");
                File.WriteLine("18|Galletas Triki-Trakes|30.00");
                File.WriteLine("19|Galletas Barritas| 27.00");
                File.WriteLine("20|Cereal Chocokrispis 450g|35.00");
                File.WriteLine("21|Cereal Zucaritas 450g|35.00");
                File.WriteLine("22|Cereal Pop Corn 450g| 37.00");
                File.WriteLine("23|Cereal Corn Flakes 450g|36.00");
                File.WriteLine("24|Yogurth Lala 100g|28.00");
                File.WriteLine("25|Yogurth Yoplait|32.00");
                File.WriteLine("26|Yogurth Activia|33.00");
                File.WriteLine("27|Desodorante Axe Aerosol|28.00");
                File.WriteLine("28|Desodorante Axe Barra|32.00");
                File.WriteLine("29|Desodorante Adidas Barra|31.00");
                File.WriteLine("30|Desodorante Adidas Aerosol|25.00");
                File.WriteLine("31|Papel higiénico 8 rollos|45.00");
                File.WriteLine("32|Chocolate KitKat barra|15.00");
                File.WriteLine("33|Papas Pringles|40.00");
                File.WriteLine("34|Crema Ácida alpura|11.90");
                File.WriteLine("35|Leche Alpura Normal|19.90");
                File.WriteLine("36|Nutrileche Tripack|45.55");
                File.WriteLine("37|Cafe Nescafe 500g|59.99");
                File.WriteLine("38|Cafe Punta de Cielo|79.99");
                File.WriteLine("39|Cafe artesanal colombiano|69.99");
                File.WriteLine("40|Huevos Bachoco paq 18|35.50");
                File.WriteLine("41|Huevos Orgánicos paq 6|19.99");
                File.WriteLine("42|Paquete de Carne Molida 90-10|80.01");
                File.WriteLine("43|Paquete de pechuga de pollo entera|50.01");
                File.WriteLine("44|Filete Robalo|40.01");
                File.WriteLine("45|Lata de sardinas Dolores|30.01");
                File.WriteLine("46|TV Samsung 65 Pulgadas 2160p 4K Ultra HD Curvo|15,99.00");
                File.WriteLine("47|Combo Supra Parrilla 5 Quemadores|10,299.00");
                File.WriteLine("48|Smartphone Xiaomi MI 9T 128 GB Azul|6,699.00");
                File.WriteLine("49|Asador Char-Griller Pro Deluxe Barrel Negro|2,938.00");
                File.WriteLine("50|Team Sonic Racing Nintendo Switch|1,999.00");
                File.WriteLine("51|Purificador de Aire Honeywell HPA300 con Filtro|9,319.00");
                File.WriteLine("52|Crema de whisky Baileys red velvet cupcake 750ml|359.00");
                File.WriteLine("53|All in One HP 24-f000tla AMD A6-9225 4GB RAM|9,499.00");
                File.WriteLine("54|Fresas 454 g|69.00");
                File.WriteLine("55|Café molido Garat americano regular 1kg|199.00");
                File.WriteLine("56|Cerveza clara Pulaner original muncher hell|69.50");
                File.WriteLine("57|Cerveza importada Budweiser 6 botellas de 350 ml|102.00");
                File.WriteLine("58|Cerveza Blue Moon belgan white 355ml|46.70");
                File.WriteLine("59|Cerveza importada Stella Artois 6 botellas 355ml|109.00");
                File.WriteLine("60|Cerveza oscura Erdinger dunkel botella|70.50");
                File.WriteLine("61|Cerveza oscura Delirium Nocturnum|83.00");
                File.WriteLine("62|Cerveza oscura Guinness draught lata|39.00");
                File.WriteLine("63|Cerveza oscura Minerva stout 6|173.00");
                File.WriteLine("64|Cerveza importada Stella Artois Combo 12|200.00");
                File.WriteLine("65|Cerveza clara Erdinger weissbier 500ml|70.50");
                File.WriteLine("66|Cerveza clara Tecate light 12 latas de 355 ml|174.00");
                File.WriteLine("67|Cerveza clara Modelo Especial 6 latas de 355ml|77.00");
                File.WriteLine("68|Cerveza clara Corona extra 12 latas de 355ml|147.00");
                File.WriteLine("69|Cerveza clara Corona Extra 12 botellas de 255ml|159.00");
                File.WriteLine("70|Cerveza clara Coronita extra 12 botellas de 210ml|120.00");
            
            }
        }
    }
   
}
