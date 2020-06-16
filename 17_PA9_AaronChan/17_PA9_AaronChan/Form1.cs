using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_PA9_AaronChan
{
    public partial class txt_convetedAmt : Form
    {
        public txt_convetedAmt()
        {
            InitializeComponent();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double AmountEntered;
            double convertedValue;

            if((rdb_USdollars.Checked == false) || (rdb_JapaneseYen.Checked == false) || (rdb_MYR.Checked == false))
            {
                txt_convertedAmt.Text = "Select at least one type of currency to convert";
            }

            if(rdb_USdollars.Checked == true && txt_amount.TextLength >= 1)
            {
                AmountEntered = double.Parse(txt_amount.Text);
                convertedValue = AmountEntered * 0.74;

                txt_convertedAmt.Text = convertedValue.ToString();
            }

            if (rdb_JapaneseYen.Checked == true && txt_amount.TextLength >= 1)
            {
                AmountEntered = double.Parse(txt_amount.Text);
                convertedValue = AmountEntered * 81.97;

                txt_convertedAmt.Text = convertedValue.ToString();
            }

            if (rdb_MYR.Checked == true && txt_amount.TextLength >= 1)
            {
                AmountEntered = double.Parse(txt_amount.Text);
                convertedValue = AmountEntered * 3.01;

                txt_convertedAmt.Text = convertedValue.ToString();
            }

            if (txt_amount.TextLength == 0 && (rdb_USdollars.Checked == false) || (rdb_JapaneseYen.Checked == false) || (rdb_MYR.Checked == false))
            {
                txt_convertedAmt.Text = "Please Enter a Number and Checked One of these Currency";
            }

            if (txt_amount.TextLength == 0 && (rdb_USdollars.Checked == true) || (rdb_JapaneseYen.Checked == true) || (rdb_MYR.Checked == true))
            {
                txt_convertedAmt.Text = "Please Enter a Number";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_convertedAmt.Text = "";
            txt_amount.Text = "";          

            rdb_USdollars.Checked = false;
            rdb_JapaneseYen.Checked = false;
            rdb_MYR.Checked = false;
        }

        private void rdb_USdollars_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
