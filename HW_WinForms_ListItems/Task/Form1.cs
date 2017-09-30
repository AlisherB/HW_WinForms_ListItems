using System;
using System.Windows.Forms;
using System.Timers;
namespace Task
{
    public partial class OilAndCafe : Form
    {
        private int priceGas80 = 90, priceGas92 = 140, priceGas95 = 150;
        System.Timers.Timer timer;
        public OilAndCafe()
        {
            InitializeComponent();
        }

        private void ComboBoxGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGas.Text == "АИ-80")
            {
                textBoxPriceGas.Text = priceGas80.ToString();
            }
            else if (comboBoxGas.Text == "АИ-92")
            {
                textBoxPriceGas.Text = priceGas92.ToString();
            }
            else if (comboBoxGas.Text == "АИ-95")
            {
                textBoxPriceGas.Text = priceGas95.ToString();
            }
        }

        private void RadioButtonGasCount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGasCount.Checked)
            {
                groupBoxGasToPay.Text = "К оплате:";
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
                groupBoxGasToPay.Text = "К выдаче:";
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
        private int sumTotal = 0;
        private int countHotDog = 0, countGamb = 0, countFri = 0, countCola = 0;
        private int priceHot = 250;
        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            if (checkBoxHotDog.Checked | checkBoxGamburger.Checked | checkBoxFri.Checked | checkBoxCola.Checked)
            {
                int priceHotDog = Int32.Parse(textBoxPriceHotDog.Text);

                if (checkBoxHotDog.Checked)
                {
                    if (textBoxCountHotDog.Text != null)
                    {
                        bool resHotDog = Int32.TryParse(textBoxCountHotDog.Text, out countHotDog);
                        sumProduct += priceHotDog * countHotDog;
                    }
                }

                int priceGamb = Int32.Parse(textBoxPriceGamb.Text);

                if (checkBoxGamburger.Checked)
                {
                    if (textBoxCountGamb.Text != null)
                    {
                        bool resGamb = Int32.TryParse(textBoxCountGamb.Text, out countGamb);
                        sumProduct += priceGamb * countGamb;
                    }
                }

                int priceFri = Int32.Parse(textBoxPriceFri.Text);

                if (checkBoxFri.Checked)
                {
                    if (textBoxCountFri.Text != null)
                    {
                        bool resFri = Int32.TryParse(textBoxCountFri.Text, out countFri);
                        sumProduct += priceFri * countFri;
                    }
                }

                int priceCola = Int32.Parse(textBoxPriceCola.Text);

                if (checkBoxCola.Checked)
                {
                    if (textBoxCountCola.Text != null)
                    {
                        bool resCola = Int32.TryParse(textBoxCountCola.Text, out countCola);
                        sumProduct += priceCola * countCola;
                    }
                }
            }
            else
            {
                sumProduct = 0;
                labelCafePayment.Text = sumProduct.ToString();
            }

            labelCafePayment.Text = sumProduct.ToString();
            timer = new System.Timers.Timer(3000);
            timer.Elapsed += new ElapsedEventHandler(ClearForm);
            timer.Enabled = true;
            //timer.Start();
            
            

        }
        private static void ClearForm(object sender, ElapsedEventArgs e)
        {
            MessageBox.Show("Очистить форму?");
            checkBoxHotDog.Checked = false;
            checkBoxGamburger.Checked = false;
            checkBoxFri.Checked = false;
            checkBoxCola.Checked = false;
        }
    }
}
