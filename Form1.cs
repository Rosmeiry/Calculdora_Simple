using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculdora_Simple
{
    public partial class CalculadoraForm : Form
    {
        double primero;
        double segundo;
        string operador; 
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMulti obj3 = new Clases.ClsMulti();
        Clases.ClsDiv obj4 = new Clases.ClsDiv();


        private void btn_0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Res;
            double Mult;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;

                case "-":
                    Res = obj2.Resta((primero), (segundo));
                    tbxScreen.Text = Res.ToString();
                    break;

                case "x":
                    Mult = obj3.Multiplicar((primero), (segundo));
                    tbxScreen.Text = Mult.ToString();
                    break;

                case "/":
                    Div = obj4.Division((primero), (segundo));
                    tbxScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btn_delete0_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btn_delete1_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else 
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
    }
}
