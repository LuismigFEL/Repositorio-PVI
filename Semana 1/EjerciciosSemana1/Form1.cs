using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosSemana1
{
    public partial class Form1 : Form
    {
        int contador = 0, intentos = 3;
        int contador2 = 0;

        public Form1()
        {
            InitializeComponent();

            ctTempInicial.TextChanged += ActualizaConversion;
            TempInicial.SelectedIndexChanged += ActualizaConversion;
            TempFinal.SelectedIndexChanged += ActualizaConversion;
        }


        //Evento para el Login
        private void btIniciar_Click(object sender, EventArgs e)
        {
            contador++;

            string username, password;
            username = ctUsuario.Text;
            password = ctContrasenia.Text;

            if (contador <= 3)
            {
                if (username == "admin" && password == "admin123")
                {
                    MessageBox.Show("Bienvenido " + username + ", Usted ha iniciado sesion correctamente");
                    contador = 0;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, intentelo otra vez\nIntentos Restantes: " + (intentos - contador));
                    if (contador == intentos)
                    {
                        MessageBox.Show("Ha superado el numero de intentos, la aplicacion se cerrara");
                        Close();


                    }
                }
            }
            else
            {
                MessageBox.Show("Ha superado el numero de intentos, la aplicacion se cerrara");
                Close();
            }
        }

        //Evento para la conversion de temperatura
        private void ActualizaConversion(object sender, EventArgs e)
        {
            string Temptext = ctTempInicial.Text;
            double Temp = 0;

            try
            {
                Temp = double.Parse(Temptext);
                string TempI = TempInicial.SelectedItem.ToString();
                string TempF = TempFinal.SelectedItem.ToString();

                double resultado = ConvertirTemperatura(Temp, TempI, TempF);
                labelTempFinal.Text = $"{resultado:F2}";

            }
            catch (FormatException)
            {
                labelTempFinal.Text = "Formato Invalido";
            }
            catch (Exception)
            {
                labelTempFinal.Text = $"Error: Sin formato asginado";
            }

        }

        private double ConvertirTemperatura(double valor, string Inicio, string Final)
        {
            double resultado = 0;

            if (Inicio == "Celsius" && Final == "Fahrenheit")
            {
                resultado = (valor * 9 / 5) + 32;
            }
            else if (Inicio == "Fahrenheit" && Final == "Celsius")
            {
                resultado = (valor - 32) * 5 / 9;
            }
            else
            {
                resultado = valor; // Si son iguales, no hay conversión
            }
            return resultado;

        }

        //evento para el IMC
        private void BtnConversion_Click(object sender, EventArgs e)
        {
            double alt, peso, imc;

            try
            {
                string Altura = ctAltura.Text;
                string Peso = ctPeso.Text;

                alt = double.Parse(Altura);
                peso = double.Parse(Peso);
                imc = ObtieneIMC(alt, peso);



                if (imc < 18.5)
                {
                    MessageBox.Show("Su IMC es: " + imc.ToString("F2") + "\nPeso inferior al normal");
                }
                else if (imc < 24.90)
                {
                    MessageBox.Show("Su IMC es: " + imc.ToString("F2") + "\nPeso normal");
                }
                else if (imc < 29.9)
                {
                    MessageBox.Show("Su IMC es: " + imc.ToString("F2") + "\nPeso superior al normal");
                }
                else
                {
                    MessageBox.Show("Su IMC es: " + imc.ToString("F2") + "\nObesidad");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato Invalido, Error: " + ex.Message + "\nIntentelo Otra vez");
            }
        }

        

        private double ObtieneIMC(double altura, double peso)
        {
            double imc = 0;

            imc = peso / (Math.Pow(altura, 2));

            return imc;
        }

        


        //evento para el contador de clics
        private void Click_Click(object sender, EventArgs e)
        {
            contador2++;
            MuestraClics.Text = contador2.ToString();
        }

        private void Reinicio_Click(object sender, EventArgs e)
        {
            contador2 = 0;
            MuestraClics.Text = contador2.ToString();
        }


    }
}
