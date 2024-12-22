using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PruebaWindowsForms
{
    public partial class Form1 : Form
    {
        private static readonly HashSet<string> combinacionesUnicas = new HashSet<string>();
        private const string RutaSalida = @"D:\Prueba\resultados.txt";

        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();

            // Ruta del archivo de sonido
            string filePath = @"C:\Users\rober\source\repos\YSE\YSE\music\hitboutit.wav";

            // Crear un objeto SoundPlayer
            soundPlayer = new SoundPlayer(filePath);

            // Reproducir el sonido en bucle
            soundPlayer.PlayLooping();
        }

        // En el caso de querer detener la música en algún momento
        private void DetenerMusica()
        {
            soundPlayer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la aplicación de búsqueda de combinaciones.");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string rutaCarpeta = textBoxCarpeta.Text;
            string palabraBusqueda = textBoxPalabra.Text;
            int opcion = int.Parse(comboBoxOpcion.SelectedItem.ToString());

            BuscarEnSubcarpetas(rutaCarpeta, palabraBusqueda, opcion);
            int lineasEscritas = EscribirContenidoEnArchivo(RutaSalida);
            MessageBox.Show($"{lineasEscritas} líneas escritas en {RutaSalida}\nProceso completado.");
        }

        private static void BuscarEnSubcarpetas(string ruta, string palabra, int opcion)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(ruta);
            if (!dirInfo.Exists)
            {
                MessageBox.Show("La ruta especificada no es una carpeta.");
            }
            else
            {
                BuscarEnArchivos(dirInfo, palabra, opcion);
                foreach (var subdir in dirInfo.GetDirectories())
                {
                    BuscarEnSubcarpetas(subdir.FullName, palabra, opcion);
                }
            }
        }

        private static void BuscarEnArchivos(DirectoryInfo dir, string palabra, int opcion)
        {
            var archivos = dir.GetFiles().Where(f => f.Name.Equals("Passwords.txt") || f.Name.Equals("All Passwords.txt")).ToArray();
            foreach (var archivo in archivos)
            {
                BuscarEnArchivo(archivo, palabra, opcion);
            }
        }

        private static void BuscarEnArchivo(FileInfo archivo, string palabra, int opcion)
        {
            try
            {
                using (StreamReader reader = new StreamReader(archivo.FullName))
                {
                    string linea;
                    string usuario = null;
                    string password = null;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (linea.StartsWith("URL:") && linea.Contains(palabra))
                        {
                            usuario = password = null;
                            while ((linea = reader.ReadLine()) != null && !string.IsNullOrWhiteSpace(linea))
                            {
                                if (linea.StartsWith("Username: ") || linea.StartsWith("USER: "))
                                {
                                    usuario = linea.Substring(linea.IndexOf(':') + 1).Trim();
                                }
                                else if (linea.StartsWith("Password: ") || linea.StartsWith("PASS: "))
                                {
                                    password = linea.Substring(linea.IndexOf(':') + 1).Trim();
                                }
                            }

                            if (usuario != null && password != null)
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        if (EsCorreoElectronico(usuario))
                                        {
                                            combinacionesUnicas.Add($"{usuario}:{password}");
                                        }
                                        break;
                                    case 2:
                                        if (!EsCorreoElectronico(usuario))
                                        {
                                            combinacionesUnicas.Add($"{usuario}:{password}");
                                        }
                                        break;
                                    case 3:
                                        combinacionesUnicas.Add($"{usuario}:{password}");
                                        break;
                                    case 4:
                                        if (EsDNI(usuario))
                                        {
                                            combinacionesUnicas.Add($"{usuario}:{password}");
                                        }
                                        break;
                                    case 5:
                                        if (EsTelefonoFijo(usuario))
                                        {
                                            combinacionesUnicas.Add($"{usuario}:{password}");
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error leyendo el archivo: {ex.Message}");
            }
        }

        private static bool EsCorreoElectronico(string texto)
        {
            return texto.Contains("@");
        }

        private static bool EsDNI(string texto)
        {
            return Regex.IsMatch(texto, @"\d{8}[A-HJ-NP-TV-Z]");
        }

        private static bool EsTelefonoFijo(string texto)
        {
            return Regex.IsMatch(texto, @"[789]\d{8}");
        }

        private static int EscribirContenidoEnArchivo(string ruta)
        {
            int lineasEscritas = 0;
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    foreach (var combinacion in combinacionesUnicas)
                    {
                        writer.WriteLine(combinacion);
                        lineasEscritas++;
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error escribiendo el archivo: {ex.Message}");
            }
            return lineasEscritas;
        }
    }
}