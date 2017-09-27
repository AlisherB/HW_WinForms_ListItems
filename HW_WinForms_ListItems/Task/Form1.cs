using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class OilAndCafe : Form
    {
        private int sumTotal = 0;
        private int priceGas;

        public OilAndCafe()
        {
            InitializeComponent();
        }

        private void ComboBoxGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGas.Text == "АИ-80")
            {
                priceGas = 90;
                textBoxPriceGas.Text = priceGas.ToString();
            }
            else if (comboBoxGas.Text == "АИ-92")
            {
                priceGas = 140;
                textBoxPriceGas.Text = priceGas.ToString();
            }
            else if (comboBoxGas.Text == "АИ-95")
            {
                priceGas = 150;
                textBoxPriceGas.Text = priceGas.ToString();
            }
        }

        private void RadioButtonGasCount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGasCount.Checked)
            {
                textBoxSumGas.Enabled = false;
                textBoxCountGas.Enabled = true;
                textBoxCountGas.Focus();
            }
            else
            {
                textBoxCountGas.Text = null;
                textBoxCountGas.Enabled = false;
            }
        }

        private void RadioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSumGas.Checked)
            {
                textBoxCountGas.Enabled = false;
                textBoxSumGas.Enabled = true;
                textBoxSumGas.Focus();
            }
            else
            {
                textBoxSumGas.Text = null;
                textBoxSumGas.Enabled = false;
            }
        }

        private void TextBoxCountGas_KeyPress(object sender, KeyPressEventArgs key)
        {
            if ((key.KeyChar <= 47 || key.KeyChar >= 59) && key.KeyChar != 8)
                key.Handled = true;
        }

        private void TextBoxSumGas_KeyPress(object sender, KeyPressEventArgs key)
        {
            if ((key.KeyChar <= 47 || key.KeyChar >= 59) && key.KeyChar != 8)
                key.Handled = true;
        }

        private void CheckBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotDog.Checked)
            {
                textBoxCountHotDog.Enabled = true;
                textBoxCountHotDog.Focus();
            }
            else
            {
                textBoxCountHotDog.Text = null;
                textBoxCountHotDog.Enabled = false;
            }
        }

        private void CheckBoxGamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGamburger.Checked)
            {
                textBoxCountGamb.Enabled = true;
                textBoxCountGamb.Focus();
            }
            else
            {
                textBoxCountGamb.Text = null;
                textBoxCountGamb.Enabled = false;
            }
        }

        private void CheckBoxFri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFri.Checked)
            {
                textBoxCountFri.Enabled = true;
                textBoxCountFri.Focus();
            }
            else
            {
                textBoxCountFri.Text = null;
                textBoxCountFri.Enabled = false;
            }
        }

        private void CheckBoxCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCola.Checked)
            {
                textBoxCountCola.Enabled = true;
                textBoxCountCola.Focus();
            }
            else
            {
                textBoxCountCola.Text = null;
                textBoxCountCola.Enabled = false;
            }
        }

        private void TextBoxHotDog_KeyPress(object sender, KeyPressEventArgs key)
        {
            if ((key.KeyChar <= 47 || key.KeyChar >= 59) && key.KeyChar != 8)
                key.Handled = true;
        }

        private void TextBoxGamb_KeyPress(object sender, KeyPressEventArgs key)
        {
            if ((key.KeyChar <= 47 || key.KeyChar >= 59) && key.KeyChar != 8)
                key.Handled = true;
        }

        private void TextBoxFri_KeyPress(object sender, KeyPressEventArgs key)
        {
            if ((key.KeyChar <= 47 || key.KeyChar >= 59) && key.KeyChar != 8)
                key.Handled = true;
        }

        private void TextBoxCola_KeyPress(object sender, KeyPressEventArgs key)
        {
            if ((key.KeyChar <= 47 || key.KeyChar >= 59) && key.KeyChar != 8)
                key.Handled = true;
        }

        private int sumProduct = 0;

        private void TextBoxCafePayment_TextChanged(object sender, EventArgs e)
        {
            int priceHotDog = Int32.Parse(textBoxPriceHotDog.Text);
            int priceGamb = Int32.Parse(textBoxPriceGamb.Text);
            int priceFri = Int32.Parse(textBoxPriceFri.Text);
            int priceCola = Int32.Parse(textBoxPriceCola.Text);

            int countHotDog, countGamb, countFri, countCola;

            if (textBoxCountHotDog.Text != null)
            {
                countHotDog = Int32.Parse(textBoxCountHotDog.Text);
                sumProduct += (priceHotDog * countHotDog);
                labelCafePayment.Text = sumProduct.ToString();
            }
            else if (textBoxCountGamb.Text != null)
            {
                countGamb = Int32.Parse(textBoxCountGamb.Text);
                sumProduct += (priceGamb * countGamb);
                labelCafePayment.Text = sumProduct.ToString();
            }
            else if (textBoxCountFri.Text != null)
            {
                countFri = Int32.Parse(textBoxCountFri.Text);
                sumProduct += (priceFri * countFri);
                labelCafePayment.Text = sumProduct.ToString();
            }
            else if (textBoxCountCola.Text != null)
            {
                countCola = Int32.Parse(textBoxCountCola.Text);
                sumProduct += (priceCola * countCola);
                labelCafePayment.Text = sumProduct.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sumTotal += (sumProduct + s 
        }
    }
}
