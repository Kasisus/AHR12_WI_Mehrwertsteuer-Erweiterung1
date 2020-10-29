using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHR12_WI_Mehrwertsteuer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double bruttobetrag = Convert.ToDouble(txtBruttobetrag19.Text), mwstbetrag = 0.00, nettobetrag = 0.00;
            string artikel = txtArtikel.Text, ausgabe = "";

            mwstbetrag = bruttobetrag / 119 * 19;
            nettobetrag = bruttobetrag / 119 * 100;
            ausgabe = "Der Netto Preis für den Artikel " + artikel + " beträgt " + nettobetrag + "€.";


            txtMwStBetrag19.Text = Convert.ToString(mwstbetrag);
            txtNettobetrag.Text = Convert.ToString(nettobetrag);
            rtbAusgabe.Text = ausgabe;     
        }
    }
}
