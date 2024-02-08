using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planejamento_Financeiro
{
    public partial class Form1 : Form
    {
        private readonly object ValorBruto;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

            int Renda, Extra, GastosM, Combustivel, Pet, Religiao, Farmacia, Luz, Agua, Internet, Obra, Diversao;

           
            
            Renda = int.Parse(textBox1.Text);
            Extra = int.Parse(textBox13.Text);
            GastosM = int.Parse(textBox2.Text);
            Combustivel = int.Parse(textBox5.Text);
            Pet = int.Parse(textBox6.Text);
            Religiao = int.Parse(textBox7.Text);
            Farmacia = int.Parse(textBox8.Text);
            Luz = int.Parse(textBox9.Text);
            Agua = int.Parse(textBox10.Text);
            Internet = int.Parse(textBox4.Text);
            Obra = int.Parse(textBox3.Text);
            Diversao = int.Parse(textBox11.Text);


            int ValorBruto = Renda+Extra;

            ValorBruto = ValorBruto-GastosM-Combustivel-Pet-Religiao-Farmacia-Luz-Agua-Internet-Obra-Diversao;
         
            textBox12.Text = ValorBruto.ToString();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox3.Visible = false;
            }
            else
            {
                textBox3.Visible = true;
            }
        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            textBox12.Text = ValorBruto.ToString();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox4.Enabled = false;
            }
            else
            { 
                textBox4.Enabled= true;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.Text = string.Empty;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Empty;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Empty;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Empty;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = string.Empty;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = string.Empty;
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = string.Empty;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.Text = string.Empty;
        }
    }
}
