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
         private void equal_Click(object sender, EventArgs e)
         {
            string TextoCompleto = TB.Text;
            Calculadora Calculo = new Calculadora();
            if (TB.Text.Contains('+'))
            {
                string[] ArreText = TextoCompleto.Split('+');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                TB.Text = Calculo.Suma().ToString();
            }
            else if(TB.Text.Contains('-'))
            {
                string[] ArreText = TextoCompleto.Split('-');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                TB.Text = Calculo.Resta().ToString();
            }
            else if (TB.Text.Contains('*'))
            {
                string[] ArreText = TextoCompleto.Split('*');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                TB.Text = Calculo.Multiplicacion().ToString();
            }
            else if(TB.Text.Contains('/'))
            {
                string[] ArreText = TextoCompleto.Split('/');
                Calculo.numero1 = Convert.ToSingle(ArreText[0]);
                Calculo.numero2 = Convert.ToSingle(ArreText[1]);
                TB.Text = Calculo.Division().ToString();
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TB.Text = "";
        }

        private void TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0) cero_Click(sender, e);
            if (e.KeyCode == Keys.NumPad1) one_Click(sender, e);
            if (e.KeyCode == Keys.NumPad2) two_Click(sender, e);
            if (e.KeyCode == Keys.NumPad3) three_Click(sender, e);
            if (e.KeyCode == Keys.NumPad4) four_Click(sender, e);
            if (e.KeyCode == Keys.NumPad5) five_Click(sender, e);
            if (e.KeyCode == Keys.NumPad6) six_Click(sender, e);
            if (e.KeyCode == Keys.NumPad7) seven_Click(sender, e);
            if (e.KeyCode == Keys.NumPad8) eight_Click(sender, e);
            if (e.KeyCode == Keys.NumPad9) nine_Click(sender, e);

            if (e.KeyCode == Keys.Decimal) dot_Click(sender, e);

            if (e.KeyCode == Keys.Add) plus_Click(sender, e);
            if (e.KeyCode == Keys.Subtract) minus_Click(sender, e);
            if (e.KeyCode == Keys.Multiply) asterisk_Click(sender, e);
            if (e.KeyCode == Keys.Divide) slash_Click(sender, e);

            if (e.KeyCode == Keys.Return) equal_Click(sender, e);
        }
    }
}
