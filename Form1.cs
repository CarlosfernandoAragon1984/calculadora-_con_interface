using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.Suma obj = new Clases.Suma();
        Clases.Resta obj1 = new Clases.Resta();
        Clases.Multiplicar obj2 = new Clases.Multiplicar();
        Clases.Dividir obj3 = new Clases.Dividir();


        private void bts0_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "0";
        }
       
        
        private void bts1_Click_1(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "1";
        }

        private void bts2_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "2";
        }

        private void bts3_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "3";
        }

        private void bts4_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "4";
        }

        private void bts5_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "5";
        }

        private void bts6_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "6";
        }

        private void bts7_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "7";
        }

        private void bts8_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "8";
        }

        private void bts9_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + "9";
        }
        private void btsLimpliar_Click(object sender, EventArgs e)
        {
            tbsText.Clear();
        }
        private void btsBorrar_Click(object sender, EventArgs e)
        {
            tbsText.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btsPunto_Click(object sender, EventArgs e)
        {
            tbsText.Text = tbsText.Text + ".";
        }

        private void btsSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbsText.Text);
            tbsText.Clear();
        }

        private void btsResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbsText.Text);
            tbsText.Clear();
        }

        private void btsMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbsText.Text);
            tbsText.Clear();
        }

        private void btsDividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbsText.Text);
            tbsText.Clear();
        }
      

        private void btsIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbsText.Text);

            double sum;
            double res;
            double mul;
            double div;
            switch (operador)
            {
                case "+":
                    sum = obj.Sumar(primero, segundo);
                    tbsText.Text = sum.ToString();
                    break;
                case "-":
                    res = obj1.Restar(primero, segundo);
                    tbsText.Text = res.ToString();
                    break;
                case "*":
                    mul = obj2.Multiplica(primero, segundo);
                    tbsText.Text = mul.ToString();
                    break;
                case "/":
                    div = obj3.Divide(primero, segundo);
                    tbsText.Text = div.ToString();
                    break;


            }


        }

        
    }
}
