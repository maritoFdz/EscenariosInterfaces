using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Escenario3
{
    public static class ConfigApp
    {
        public static string TituloApp { get; private set; }
        public static int LongitudMinimaPassword { get; private set; }
        public static int MaxIntentosFallidos { get; private set; }

        public static void Cargar()
        {
            try
            {
                string ruta = Path.Combine(Application.StartupPath, "config.xml");
                XDocument doc = XDocument.Load(ruta);

                foreach (var nodo in doc.Descendants("Parametro"))
                {
                    string nombre = nodo.Attribute("nombre").Value;
                    string valor = nodo.Value;

                    switch (nombre)
                    {
                        case "TituloApp":
                            TituloApp = valor;
                            break;
                        case "LongitudMinimaPassword":
                            LongitudMinimaPassword = int.Parse(valor);
                            break;
                        case "MaxIntentosFallidos":
                            MaxIntentosFallidos = int.Parse(valor);
                            break;
                    }
                }
            }
            catch (Exception) // por si da bateo y no encuentra el archivo
            {
                TituloApp = "Sistema de Registro (config.xml no encontrado)";
                LongitudMinimaPassword = 6;
                MaxIntentosFallidos = 3;
                MessageBox.Show("No se pudo leer el config.xml");
            }
        }
    }
}
