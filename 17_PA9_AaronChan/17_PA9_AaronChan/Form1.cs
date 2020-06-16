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

            if((rdb_USdollars.Checked == false) || (rdb_JapaneseYen.Checked == false))
            {
                txt_convertedAmt.Text = "Select at least one type of currency to convert";
            }

            if(rdb_USdollars.Checked == true)
            {
                AmountEntered = double.Parse(txt_amount.Text);
                convertedValue = AmountEntered * 0.74;

                txt_convertedAmt.Text = convertedValue.ToString();
            }

            if (rdb_JapaneseYen.Checked == true)
            {
                AmountEntered = double.Parse(txt_amount.Text);
                convertedValue = AmountEntered * 81.97;

                txt_convertedAmt.Text = convertedValue.ToString();
            }

            try
            {
                txt_convertedAmt.Text = "Please enter numbers only";
            }
            catch (FormatException)
            {

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_convertedAmt.Text = "";
            txt_amount.Text = "";

            rdb_USdollars.Checked = false;
            rdb_JapaneseYen.Checked = false;       
        }
    }
}
