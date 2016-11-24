using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_FormCurrencyCalc
{
    public partial class Form1 : Form
    {
        decimal usdBuy;
        decimal usdSale;
        decimal eurBuy;
        decimal eurSale;
        decimal gbpBuy;
        decimal gbpSale;
        decimal k;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tbUsdBuy.Text != "" && tbUsdSale.Text != "" && tbEurBuy.Text != "" && tbEurSale.Text != "" && tbGbpBuy.Text != "" && tbGbpSale.Text != "")
            {
                tbInput.Enabled = true;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            tbUsdBuy.Enabled = true;
            tbUsdSale.Enabled = true;
            tbEurBuy.Enabled = true;
            tbEurSale.Enabled = true;
            tbGbpBuy.Enabled = true;
            tbGbpSale.Enabled = true;
            btnSet.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUsdBuy.Text == "" || tbUsdSale.Text == "" || tbEurBuy.Text == "" || tbEurSale.Text == "" || tbGbpBuy.Text == "" || tbGbpSale.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    usdBuy = Convert.ToDecimal(tbUsdBuy.Text);
                    usdSale = Convert.ToDecimal(tbUsdSale.Text);
                    eurBuy = Convert.ToDecimal(tbEurBuy.Text);
                    eurSale = Convert.ToDecimal(tbEurSale.Text);
                    gbpBuy = Convert.ToDecimal(tbGbpBuy.Text);
                    gbpSale = Convert.ToDecimal(tbGbpSale.Text);

                    tbUsdBuy.Enabled = false;
                    tbUsdSale.Enabled = false;
                    tbEurBuy.Enabled = false;
                    tbEurSale.Enabled = false;
                    tbGbpBuy.Enabled = false;
                    tbGbpSale.Enabled = false;
                    btnSet.Enabled = true;
                    btnSave.Enabled = false;

                    cbCurSource.Enabled = true;
                    cbCurTarget.Enabled = true;
                    tbInput.Enabled = true;
                    btnCalc.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
           
           if (cbCurSource.Text == "USD")
            {
                switch (cbCurTarget.Text)
                {
                    case "USD":
                        k = 1;
                        break;
                    case "EUR":
                        k = usdBuy / eurSale;
                        break;
                    case "GBP":
                        k = usdBuy / gbpSale;
                        break;
                    case "UAH":
                        k = usdBuy;
                        break;                    
                }
            }
           if (cbCurSource.Text == "EUR")
            {
                switch (cbCurTarget.Text)
                {
                    case "USD":
                        k = eurBuy / usdSale;
                        break;
                    case "EUR":
                        k = 1;
                        break;
                    case "GBP":
                        k = eurBuy / gbpSale;
                        break;
                    case "UAH":
                        k = eurBuy;
                        break;
                }
            }           
            if (cbCurSource.Text == "GBP")
                {
                    switch (cbCurTarget.Text)
                    {
                        case "USD":
                            k = gbpBuy / usdSale;
                            break;
                        case "EUR":
                            k = gbpBuy / eurSale;
                            break;
                        case "GBP":
                            k = 1;
                            break;
                        case "UAH":
                            k = gbpBuy;
                            break;
                    }
                }
            if (cbCurSource.Text == "UAH")
            {
                switch (cbCurTarget.Text)
                {
                    case "USD":
                        k = 1 / usdSale;
                        break;
                    case "EUR":
                        k = 1 / eurSale;
                        break;
                    case "GBP":
                        k = 1 / gbpSale;
                        break;
                    case "UAH":
                        k = 1;
                        break;
                }
            }
            decimal tmp = Convert.ToDecimal(tbInput.Text);
            tbResult.Text = String.Format("{0:F}", tmp * k);
           // btnCalc.Enabled = false;
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (tbInput.Text.IndexOf(',') != -1 || tbInput.Text.Length == 0)
                    e.Handled = true;
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (tbInput.Text.IndexOf(',') != -1 || tbInput.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void tbUsdBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (tbUsdBuy.Text.IndexOf(',') != -1 || tbUsdBuy.Text.Length == 0)
                    e.Handled = true;
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (tbUsdBuy.Text.IndexOf(',') != -1 || tbUsdBuy.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void tbUsdSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (tbUsdSale.Text.IndexOf(',') != -1 || tbUsdSale.Text.Length == 0)
                    e.Handled = true;
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (tbUsdSale.Text.IndexOf(',') != -1 || tbUsdSale.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void tbEurBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (tbEurBuy.Text.IndexOf(',') != -1 || tbEurBuy.Text.Length == 0)
                    e.Handled = true;
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (tbEurBuy.Text.IndexOf(',') != -1 || tbEurBuy.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void tbEurSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (tbEurSale.Text.IndexOf(',') != -1 || tbEurSale.Text.Length == 0)
                    e.Handled = true;
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (tbEurSale.Text.IndexOf(',') != -1 || tbEurSale.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void tbGbpBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (tbGbpBuy.Text.IndexOf(',') != -1 || tbGbpBuy.Text.Length == 0)
                    e.Handled = true;
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (tbGbpBuy.Text.IndexOf(',') != -1 || tbGbpBuy.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void tbGbpSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (Char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '.')
            {
                if (tbGbpSale.Text.IndexOf(',') != -1 || tbGbpSale.Text.Length == 0)
                    e.Handled = true;
                else
                    e.KeyChar = ',';
                return;
            }
            if (e.KeyChar == ',')
            {
                if (tbGbpSale.Text.IndexOf(',') != -1 || tbGbpSale.Text.Length == 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        private void cbCurSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbInput.Text = "";
            tbResult.Text = "";
            //btnCalc.Enabled = true;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            if (tbInput.Text.Length > 0)
            {
                btnReset.Enabled = true;
                
            }
            else
            {
                btnReset.Enabled = false;
            }
        }
    }
}
