using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Exchange_Office_Using_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] currencyAry = new string[] { "USD", "AUD", "DKK", "EUR", "GBP", "CHF", "SEK", "CAD", "KWD", "NOK", "SAR", "JPY", "BGN", "RON", "RUB", "IRR", "CNY", "PKR","QAR", "KRW", "AZN", "AED", "XDR"};
        string[] status = new string[] { "Selling", "Buying" };
        string[,] currencies = new string[24, 2];
        private void Form1_Load(object sender, EventArgs e)
        {
            
            CbxCurrency.DataSource = currencyAry;
            string filename = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filename);
            
            for (int i = 0; i < currencyAry.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    currencies[i,j] = xmlDocument.SelectSingleNode("Tarih_Date/Currency[@Kod='" + currencyAry[i] + "']/Banknote" + status[j]).InnerXml;
                }
            }
            
            LblDolarSelling.Text = currencies[0, 0];
            LblDolarBuying.Text = currencies[0, 1];
            LblEuroSelling.Text = currencies[3, 0];
            LblEuroBuying.Text = currencies[3, 1];
        }

        private void BtUSDBuy_Click(object sender, EventArgs e)
        {
            TbxCurrency.Text = currencies[0, 1];
        }

        private void BtUSDSell_Click(object sender, EventArgs e)
        {
            TbxCurrency.Text = currencies[0, 0];
        }

        private void BtEURBuy_Click(object sender, EventArgs e)
        {
            TbxCurrency.Text = currencies[3, 1];
        }

        private void BtEURSell_Click(object sender, EventArgs e)
        {
            TbxCurrency.Text = currencies[3, 0];
        }

        private void BtExchange_Click(object sender, EventArgs e)
        {
            double currencyPrice, amount, total;
            currencyPrice = Convert.ToDouble(TbxCurrency.Text);
            amount = Convert.ToDouble(TbxAmount.Text);
            total = currencyPrice * amount;
            TbxTotal.Text = total.ToString();
        }
    }
}
