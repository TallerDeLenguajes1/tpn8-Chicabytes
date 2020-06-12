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
        public Form1()
        {
            InitializeComponent();
        }

        private void cero_Click(object sender, EventArgs e)
        {
            TB.Text += "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            TB.Text += ".";
        }

       
        private void slash_Click(object sender, EventArgs e)
        {
            TB.Text += "/";
        }

        private void asterisk_Click(object sender, EventArgs e)
        {
            TB.Text += "*";
        }

        private void three_Click(object sender, EventArgs e)
        {
            TB.Text += "3";
        }

        private void two_Click(object sender, EventArgs e)
        {
            TB.Text += "2";
        }

        private void one_Click(object sender, EventArgs e)
        {
            TB.Text += "1";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            TB.Text += "-";
        }

        private void six_Click(object sender, EventArgs e)
        {
            TB.Text += "6";
        }

        private void five_Click(object sender, EventArgs e)
        {
            TB.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            TB.Text += "4";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            TB.Text += "+";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            TB.Text += "9";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            TB.Text += "8";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            TB.Text += "9";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TB.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            string TextoCompleto = TB.Text;
            Calculadora Calculo = new Calculadora();
            Calculo.fecha = DateTime.Now;

            if (TB.Text.Contains('+'))
            {
                string[] ArreText = TextoCompleto.Split('+');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                Calculo.Operador = '+';
                TB.Text = Calculo.Operacion().ToString();
                Lista.Items.Add(Calculo);
                Lista.Refresh();
            }
            else if (TB.Text.Contains('-'))
            {
                string[] ArreText = TextoCompleto.Split('-');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                Calculo.Operador = '-';
                TB.Text = Calculo.Operacion().ToString();
                Lista.Items.Add(Calculo);
                Lista.Refresh();
            }
            else if (TB.Text.Contains('*'))
            {
                string[] ArreText = TextoCompleto.Split('*');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                Calculo.Operador = '*';
                TB.Text = Calculo.Operacion().ToString();
                Lista.Items.Add(Calculo);
                Lista.Refresh();
            }
            else if (TB.Text.Contains('/'))
            {
                string[] ArreText = TextoCompleto.Split('/');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                Calculo.Operador = '/';
                if (Calculo.Operacion() == 0)
                {
                    TB.Text = "Indefinido";
                }
                else
                {
                    TB.Text = Calculo.Operacion().ToString();
                }
                Lista.Items.Add(Calculo);
                Lista.Refresh();
            }

        }

        private void Lista_DoubleClick(object sender, EventArgs e)
        {
            Lista.Items.Remove(Lista.SelectedItem);
        }
    }
}
