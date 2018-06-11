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
            labelPalabra.Text = ahorcado.getPalabra();
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
                //Se guarda en un txt

                //
                String line;
                String todoElArchivo = "";
                TimeSpan registros;
                int j = 0;
                StreamReader sr = new StreamReader("DatosTiempo.txt"); //Direccion correcta?
                //Se deben guardar los tiempos en orden
                //Pienso guardarlos como:
                //nombre
                //tiempo 
                //(etc)
                //Se lee la primera linea
                line = sr.ReadLine();

                //Se sigue leyendo hasta el final del archivo
                while (line != null)
                {
                    //Si es un tiempo
                    if (j % 2 != 0)
                    {
                        //La linea se convierte en TimeSpan
                        registros = TimeSpan.Parse(line);
                        if (total >= registros)
                        {
                            todoElArchivo += nombreUsuario + "\n";
                            todoElArchivo += registros + "\n";
                        }
                    }
                    j++;
                    todoElArchivo += line + "\n"; //Ocupa \n ?
                    //Se lee la siguiente linea
                    line = sr.ReadLine();
                }
                sr.Close();

                StreamWriter sw = new StreamWriter("DatosTiempo.txt");
                sw.WriteLine(todoElArchivo);
                sw.Close();


                //





            }
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

            }
        }

        private void buttonNuevaPalabra_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            reinicio = new Inicio();
            reinicio.Show();
            this.Hide();
        }
    }
}
