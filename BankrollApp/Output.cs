using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankrollApp
{
    class Output
    {

        public static void PrintData(string info, string csv)
        {
            TextWriter tw = new StreamWriter("bankroll.txt", true);
            tw.WriteLine(info);
            tw.Close();
            PrintDataCsv(csv);
            //TextWriter twcsv = new StreamWriter("bankrollcsv.csv"); //StreamWriter("bankrollcsv.csv", true);
            //twcsv.WriteLine(csv);
            //twcsv.Close();
            Application.Exit();
        }

        public static void PrintDataCsv(string csv)
        {
            TextWriter twcsv = new StreamWriter("bankrollcsv.csv"); //StreamWriter("bankrollcsv.csv", true);
            twcsv.WriteLine(csv);
            twcsv.Close();
        }

        //public static void ErrorMessage()
        //{
        //    Form2ErrorMessage errorMessage = new Form2ErrorMessage();
        //    errorMessage.Show(this);
        //}


    }
}
