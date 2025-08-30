using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSemana2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        double num3 = 0;
        double memoria = 0;


        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            labelSalidaSol.Text = "0";
            labelProcedimiento.Text = "";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btnBorrarElemento_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text.Length == 1)
            {
                labelSalidaSol.Text = "0";
            }
            else
            {
                labelSalidaSol.Text = labelSalidaSol.Text.Substring(0, labelSalidaSol.Text.Length - 1);
            }
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            string compare = num1.ToString();
            if (labelSalidaSol.Text == "0" || labelSalidaSol.Text == compare)
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "9";
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            labelSalidaSol.Text = labelSalidaSol.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            labelSalidaSol.Text = labelSalidaSol.Text + ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(labelSalidaSol.Text);
            labelProcedimiento.Text = labelSalidaSol.Text + " + ";
            labelSalidaSol.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(labelSalidaSol.Text);
            labelProcedimiento.Text = labelSalidaSol.Text + " - ";
            labelSalidaSol.Text = "0";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(labelSalidaSol.Text);
            labelProcedimiento.Text = labelSalidaSol.Text + " * ";
            labelSalidaSol.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(labelSalidaSol.Text);
            labelProcedimiento.Text = labelSalidaSol.Text + " / ";
            labelSalidaSol.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (labelSalidaSol.Text.Contains("%")){
                
                double n1 = 0, n2 = 0;
                int contador = labelSalidaSol.Text.ToString().Length-1, i = 0;
                string recorrido = "";
                //bool v = false;
                if (labelSalidaSol.Text.Last() == '%')
                {
                    MessageBox.Show("Por favor, digite el segundo numero");
                }
                else
                {
                    foreach (char c in labelSalidaSol.Text.ToString())
                    {
                        
                        if (c == '%')
                        {
                            n1 = Convert.ToDouble(recorrido);
                            recorrido = "";
                            i++;

                        }
                        else
                        {
                            recorrido += c;
                            i++;
                            if (i > contador)
                            {
                                n2 = Convert.ToDouble(recorrido);
                                recorrido = "";
                            }

                        }
                        // recorrido = "";
                    }
                    labelProcedimiento.Text += labelSalidaSol.Text;
                    labelSalidaSol.Text = $"{((n2 * n1) / 100)}";
                }
                    
            }

            else
            {
                num2 = Convert.ToDouble(labelSalidaSol.Text);

                switch (operador)
                {
                    case "+":
                        labelProcedimiento.Text += labelSalidaSol.Text;
                        labelSalidaSol.Text = $"{num1 + num2}";
                        break;
                    case "-":
                        labelProcedimiento.Text += labelSalidaSol.Text;
                        labelSalidaSol.Text = $"{num1 - num2}";
                        break;
                    case "*":
                        labelProcedimiento.Text += labelSalidaSol.Text;
                        labelSalidaSol.Text = $"{num1 * num2}";
                        break;
                    case "/":
                        labelProcedimiento.Text += labelSalidaSol.Text;
                        labelSalidaSol.Text = $"{num1 / num2}";
                        break;
                }
            }


               
        }

        private void btnLogN_Click(object sender, EventArgs e)
        {
            num3 = Convert.ToDouble(labelSalidaSol.Text.ToString());
            labelSalidaSol.Text = Math.Log(num3).ToString();
            labelProcedimiento.Text = $"ln({num3})";
            /*
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
                labelSalidaSol.Text = labelSalidaSol.Text + "(";
            }
            else
            {
                if (string.IsNullOrEmpty(labelSalidaSol.Text.ToString()))
                {
                    labelSalidaSol.Text = "(";
                }
                else
                {
                    labelSalidaSol.Text = labelSalidaSol.Text + "(";
                }
            }
            */
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {

            labelSalidaSol.Text = Math.E.ToString();


            /*
            if (labelSalidaSol.Text == "0")
            {
                labelSalidaSol.Text = "";
            }
            else
            {
                if (string.IsNullOrEmpty(labelSalidaSol.Text.ToString()))
                {
                    //labelOutCal.Text = ")";
                    labelSalidaSol.Text = labelSalidaSol.Text + ")";
                }
                else if(labelSalidaSol.Text.Contains("("))
                {
                    labelSalidaSol.Text = labelSalidaSol.Text + ")";
                }
            }
            */
                
        }

        private void btnPotenciaCuadrada_Click(object sender, EventArgs e)
        {
            double num3 = 0;

            num3 = Convert.ToDouble(labelSalidaSol.Text.ToString());

            labelSalidaSol.Text = Math.Pow(num3, 2).ToString();
            labelProcedimiento.Text = $"sqr({num3})";

        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            num3 = Convert.ToDouble(labelSalidaSol.Text.ToString());

            labelSalidaSol.Text = Math.Sqrt(num3).ToString();
            labelProcedimiento.Text = $"√({num3})";
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            labelSalidaSol.Text = Math.PI.ToString();
        }

        private void btnLogaritmo_Click(object sender, EventArgs e)
        {
            num3 = Convert.ToDouble(labelSalidaSol.Text.ToString());
            labelSalidaSol.Text = Math.Log10(num3).ToString();
            labelProcedimiento.Text = $"log({num3})";
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            if(!(labelSalidaSol.Text.ToString() == "" || labelSalidaSol.Text.ToString() == "0"))
            {
                labelSalidaSol.Text += "%";
            }
        }

        private void btnSaveInMemory_Click(object sender, EventArgs e)
        {
            memoria = Convert.ToDouble(labelSalidaSol.Text);
        }

        private void btnReadMemSave_Click(object sender, EventArgs e)
        {
            labelSalidaSol.Text = memoria.ToString();
        }

        private void btnDeleteMemSave_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btnResMemSave_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(labelSalidaSol.Text);
            memoria -= numero;
        }

        private void btnSumMemSave_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(labelSalidaSol.Text);
            memoria += numero;
        }
    }
}
