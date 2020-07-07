using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankrollApp
{
    class Data
    {
        string PokerSite { get; set; }
        string PokerCurrency { get; set; }
        decimal EntryFee { get; set; }
        decimal PrizeMoney { get; set; }

        const decimal DOLLAR_VALUE = 0.8m;
        const decimal EURO_VALUE = 0.9m;

        public Data (string site, string currency, decimal entry, decimal prize)
        {
            PokerSite = site;
            PokerCurrency = currency;
            EntryFee = entry;
            PrizeMoney = prize;
            decimal winLoss = PrizeMoney - EntryFee;

            if (PokerCurrency == "$")
            {
                winLoss *= DOLLAR_VALUE;
            }
            if (PokerCurrency == "€")
            {
                winLoss *= EURO_VALUE;
            }
            if (PokerCurrency != null && PokerSite != null) {
                Output.PrintData(GameInfo(winLoss), GameInfoCsv());
                               
                Application.Exit();       
            }            
            
            
        }

        public string GameInfo(decimal d)
        {
            string winString = d.ToString();
            return $"{DateTime.Now}  Site: {PokerSite}  Entry: {PokerCurrency}{EntryFee}  Prize: {PokerCurrency}{PrizeMoney}  Win/Loss: £{d}";
        }

        public string GameInfoCsv()
        {
            if (PokerCurrency == "$") { EntryFee *= DOLLAR_VALUE;
                PrizeMoney *= DOLLAR_VALUE;
            }
            else if (PokerCurrency == "€") { EntryFee *= EURO_VALUE;
                PrizeMoney *= EURO_VALUE;
            }
            return $"{DateTime.Now.ToString()}, {PokerSite}, {EntryFee}, {PrizeMoney}";
        }
    }
}
