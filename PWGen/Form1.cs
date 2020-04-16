using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PWGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly Random rnd = new Random();

        private Dictionary<String, int> dVon = new Dictionary<String, int>();
        private Dictionary<String, int> dBis = new Dictionary<String, int>();


        private void bStart_Click(object sender, EventArgs e)
        {
            String ausgabe = "";
            List<String> wasAlles = new List<String>();
            int wieviel = 0;

            if (cbZahlen.Checked)
            {
                wieviel++;
                wasAlles.Add("num");
            }
            if (cbGrosbuchstaben.Checked)
            {
                wieviel++;
                wasAlles.Add("gb");
            }
            if (cbKleinbuchstaben.Checked)
            {
                wieviel++;
                wasAlles.Add("kb");
            }
            if (cbSonderzeichen.Checked)
            {
                wieviel++;
                wasAlles.Add("sz");
            }

            for (int i = 0; i < nudAnzahl.Value; i++)
            {
                ausgabe = ausgabe + RandomChar(wieviel, wasAlles);
            }

            tbAusgabe.Text = ausgabe;
        }

        

        private char RandomChar(int wieviel, List<String> wasAlles)
        {
            int was = 0, i = 0;
            
            if (wieviel > 0)
            {
                was = rnd.Next((wieviel));

                if (wasAlles[was] == "sz")
                {
                    int wasGenau = rnd.Next(1,4);
                    i = rnd.Next(dVon[("sz" + wasGenau)],dBis[("sz" + wasGenau)]);
                }
                else
                {
                    i = rnd.Next(dVon[wasAlles[was]], dBis[wasAlles[was]]);
                }

            }

            return (char) i;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dVon.Add("num", 48);
            dBis.Add("num", 57);

            dVon.Add("gb", 65);
            dBis.Add("gb", 90);

            dVon.Add("kb", 97);
            dBis.Add("kb", 122);

            dVon.Add("sz1", 33);
            dBis.Add("sz1", 47);

            dVon.Add("sz2", 58);
            dBis.Add("sz2", 64);

            dVon.Add("sz3", 91);
            dBis.Add("sz3", 96);

            dVon.Add("sz4", 123);
            dBis.Add("sz4", 126);

            nudAnzahl.Select(0,2);
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tbAusgabe.Text, true);
        }

        private void nudAnzahl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bStart_Click(null,null);
                bCopy.Select();
            }
        }
    }
}
