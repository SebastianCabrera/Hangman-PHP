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
    public partial class Form1 : Form
    {
        Inicio reinicio;
        private ECCI_Ahorcado.ECCI_AhorcadoPortClient ahorcado;
        String escondida = "";
        String repetidas = "";
        String nombreUsuario = "";
        DateTime tiempo1;
        DateTime tiempo2;

        public Form1(string nombre)
        {
            InitializeComponent();
            //Nombre que se guardaria en la tabla de tiempos
            nombreUsuario = nombre;
            labelAviso.Visible = false;
            //Inicializa los valores requeridos (constructor)
            ahorcado = new ECCI_Ahorcado.ECCI_AhorcadoPortClient();
            //Para ver la palabra que hay que averiguar, la cual se eligió al azar de la lista
            //labelPalabra.Text = ahorcado.getPalabra();
            labelPalabra.Text = " ";
            escondida = ahorcado.palabraEscondida();
            //Se asigna la palabra escondida. Al principio deberia ser una sucesion de '_'
            labelEscondida.Text = "";
            for (int i = 0; i < escondida.Length; i++)
            {
                labelEscondida.Text += escondida[i] + " ";
            }
            //Muestra el numero de intentos fallidos (cero porque esta comenzando)
            labelIntentos.Text = "Lleva 0/9 intentos fallidos";
            labelMensaje.Text = " - ";
            //Va a mostrar las letras que ya se hayan usado
            labelRepetidas.Text = " ";
            //Inicializar imagenes
            imageList1 = new ImageList();
            imageList1.Images.Add(Properties.Resources._0);
            imageList1.Images.Add(Properties.Resources._1);
            imageList1.Images.Add(Properties.Resources._2);
            imageList1.Images.Add(Properties.Resources._3);
            imageList1.Images.Add(Properties.Resources._4);
            imageList1.Images.Add(Properties.Resources._5);
            imageList1.Images.Add(Properties.Resources._6);
            imageList1.Images.Add(Properties.Resources._7);
            imageList1.Images.Add(Properties.Resources._8);
            imageList1.Images.Add(Properties.Resources._9);
            //Para mostrar las imagenes (aun no funciona)
            Image im = imageList1.Images[0];
            labelImagen.Image = im;
            //Para contar cuanto tiempo le duro completar la palabra
            tiempo1 = DateTime.Now;
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            labelAviso.Visible = false;
            String antesVerif = escondida;
            escondida = ahorcado.verificarLetra(textBoxLetra.Text.ToString(), escondida);

            //Actualiza la palabra escondida
            labelEscondida.Text = "";
            for (int i = 0; i < escondida.Length; i++)
            {
                labelEscondida.Text += escondida[i] + " ";
            }
            repetidas = ahorcado.getletrasIngresadas();
            //Actualiza la lista de letras que se han usado
            labelRepetidas.Text = "";
            for (int i = 0; i < repetidas.Length; i++)
            {
                labelRepetidas.Text += repetidas[i] + "-";
            }
            String antesActualizar = labelIntentos.Text;
            //Actualiza el numero de intentos realizados
            labelIntentos.Text = "Lleva " + ahorcado.getIntentos() + "/9 intentos fallidos";
            //Si el caracter era invalido o repetido
            if (escondida == antesVerif && labelIntentos.Text == antesActualizar)
            {
                labelAviso.Visible = true;
            }
            //Aparece un mensaje si ganó o perdió (vacío si no ha terminado el juego)
            labelMensaje.Text = ahorcado.verificarResultadoDeJuego(escondida);
            //Si se termina el juego el boton de verificar se desactiva
            if (labelMensaje.Text == "Felicidades" || labelMensaje.Text == "Perdiste")
            {
                buttonVerificar.Enabled = false;
                buttonVerificar.Text = "-";
            }
            //Si se ganó el juego se toma el tiempo que le duró y se guarda
            if (labelMensaje.Text == "Felicidades")
            {
                tiempo2 = DateTime.Now;
                TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);

                labelPalabra.Text = nombreUsuario + "-" + total.ToString("c");

                //Se guarda en un txt

                TimeSpan registros;
                int j = 0;


                /*
                //La lista esta vacia
                if (line == null)
                {
                    
                }
                */

                string line;
                var sb = new StringBuilder();
                System.IO.StreamReader file = new System.IO.StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
                                                                + "\\DatosTiempo.txt");
                Boolean fueGuardado = false;
                String[] substrings;
                while ((line = file.ReadLine()) != null && j <= 9)
                {
                    substrings = line.Split('-');
                    registros = TimeSpan.Parse(substrings[1]);
                    if (total <= registros && fueGuardado == false)
                    {
                        sb.AppendLine(nombreUsuario + "-" + total.ToString("c"));
                        sb.AppendLine(line);
                        fueGuardado = true;
                    }
                    else
                    {
                        sb.AppendLine(line);
                    }
                    j++;
                }
                if (fueGuardado == false && j <= 9)
                {
                    sb.AppendLine(nombreUsuario + "-" + total.ToString("c"));
                }
                file.Close();
                using (System.IO.StreamWriter files = new System.IO.StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
                                                                    + "\\DatosTiempo.txt"))
                {
                    files.WriteLine(sb.ToString().Substring(0, sb.ToString().Length - 2));
                }

                /*
                StreamWriter sw = new StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
                                                                        + "\\DatosTiempo.txt");
                sw.WriteLine(todoElArchivo);
                sw.Close();
                */
            } //fin de Felicidades

            switch (ahorcado.getIntentos())
            {
                case 0:
                    labelImagen.Image = imageList1.Images[0];
                    break;
                case 1:
                    labelImagen.Image = imageList1.Images[1];
                    break;
                case 2:
                    labelImagen.Image = imageList1.Images[2];
                    break;
                case 3:
                    labelImagen.Image = imageList1.Images[3];
                    break;
                case 4:
                    labelImagen.Image = imageList1.Images[4];
                    break;
                case 5:
                    labelImagen.Image = imageList1.Images[5];
                    break;
                case 6:
                    labelImagen.Image = imageList1.Images[6];
                    break;
                case 7:
                    labelImagen.Image = imageList1.Images[7];
                    break;
                case 8:
                    labelImagen.Image = imageList1.Images[8];
                    break;
                case 9:
                    labelImagen.Image = imageList1.Images[9];
                    break;
                default:
                    labelImagen.Image = imageList1.Images[9];
                    break;
            }
        }
            /*
            switch (ahorcado.getIntentos())
            {
                case 0:
                    labelImagen.Image = imageList1.Images[0];
                    break;
                case 1:
                    labelImagen.Image = imageList1.Images[1];
                    break;
                case 2:
                    labelImagen.Image = imageList1.Images[2];
                    break;
                case 3:
                    labelImagen.Image = imageList1.Images[3];
                    break;
                case 4:
                    labelImagen.Image = imageList1.Images[4];
                    break;
                case 5:
                    labelImagen.Image = imageList1.Images[5];
                    break;
                case 6:
                    labelImagen.Image = imageList1.Images[6];
                    break;
                case 7:
                    labelImagen.Image = imageList1.Images[7];
                    break;
                case 8:
                    labelImagen.Image = imageList1.Images[8];
                    break;
                case 9:
                    labelImagen.Image = imageList1.Images[9];
                    break;
                default:
                    labelImagen.Text = "No hay nada";
                    break;

            }
            */
           

        private void buttonNuevaPalabra_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            reinicio = new Inicio();
            reinicio.Show();
            this.Hide();
        }
    }
}
