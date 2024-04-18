using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace ZH2_tacueo
{
    public partial class Form1 : Form
    {
        BindingList<Infok> inf�k = new BindingList<Infok>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("konyv.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Infok>();

                foreach (var item in t�mb)
                {
                    { inf�k.Add(item); }
                }

                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            infokBindingSource.DataSource = inf�k;


        }

        private void Betoltes_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);

                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);

                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (infokBindingSource.Current == null)
            {
                return;
            }

            if (MessageBox.Show("T�NYLEG NE", "K�rlek ne nyomj az igenre", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                infokBindingSource.RemoveCurrent();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            HozzaAdas hozzaAdas = new HozzaAdas();
            hozzaAdas.UjInfok = infokBindingSource.AddNew() as Infok;
            hozzaAdas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (infokBindingSource.Current == null)
            {
                return;
            }


            int OLdalak = 0;
            int kiadas = 0;

            int szamlalo = 0;
            int �sszeg = 0;

           

            foreach (var item in inf�k)
            {
                if(item.Oldalszam > OLdalak)
                {
                    OLdalak = item.Oldalszam;
                    kiadas = item.KiadasEve;
                }

                if (item.KiadasEve > 2000)
                {
                    szamlalo ++;
                    �sszeg += item.Oldalszam;
                }

                
            }

            int Vegs��sszeg = �sszeg / szamlalo;

            MessageBox.Show($"A leghosszabb k�nyv {kiadas}-ban lett kiadva. A 2000-ut�ni k�nyvek �tlagosan {Vegs��sszeg} oldal hossz�ak");
        }
    }
}