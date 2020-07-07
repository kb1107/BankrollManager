using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankrollApp
{
    public partial class BankrollApp : Form
    {
        string SiteSelected { get; set; }
        string Currency { get; set; }
        decimal EntryMoney { get; set; }
        decimal PrizeMoney { get; set; }
        public BankrollApp()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SiteSelected = comboBoxPokerSite.Text;
        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownPrizeMoney_ValueChanged(object sender, EventArgs e)
        {
            PrizeMoney = PrizeAmount.Value;
        }

        private void radioButtonDollar_CheckedChanged(object sender, EventArgs e)
        {
            Currency = "$";
        }

        private void radioButtonPound_CheckedChanged(object sender, EventArgs e)
        {
            Currency = "£";
        }

        private void radioButtonEuro_CheckedChanged(object sender, EventArgs e)
        {
            Currency = "€";
        }

        private void EntryFee_ValueChanged(object sender, EventArgs e)
        {
            EntryMoney = EntryFeeAmount.Value;
        }


        private void FinalClick(object sender, EventArgs e)
        {
            if (SiteSelected == null || Currency == null)
            {
                Form2ErrorMessage errorMessage = new Form2ErrorMessage();
                errorMessage.Show(this);
            }
            Data d = new Data(SiteSelected, Currency, EntryMoney, PrizeMoney);
        }

        private void comboBoxPokerSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            SiteSelected = comboBoxPokerSite.Text;
        }
    }
}
