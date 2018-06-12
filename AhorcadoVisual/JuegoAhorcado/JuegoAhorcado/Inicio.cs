using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JuegoAhorcado
{
    public partial class Inicio : Form
    {
        Form1 inicio; 

        public Inicio()
        {
            InitializeComponent();
            String line;
            labelInfoMejorTiempo.Text = "";
            try
            {
                //El directorio del archivo de texto
                StreamReader sr = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName 
                                                                        + "\\DatosTiempo.txt");

                //Lee la primera linea
                line = sr.ReadLine();
                int i = 0;

                
                //Sigue leyendo hasta el final del doc
                //o hasta que se encuentren los 10 marcadores
                while (line != null && i<=9)
                {
                    labelInfoMejorTiempo.Text += line + "\n";
                    i++;
                    line = sr.ReadLine();
                }
                
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            // labelInfoMejorTiempo.Text += 
        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            inicio = new Form1(textBoxNombre.Text);
            inicio.Show();
            this.Hide();
        }
    }
}
