using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace ZH2_tacueo
{
    public partial class Form1 : Form
    {
        BindingList<Infok> infók = new BindingList<Infok>();
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
                var tömb = csv.GetRecords<Infok>();

                foreach (var item in tömb)
                {
                    { infók.Add(item); }
                }

                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            infokBindingSource.DataSource = infók;


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

            if (MessageBox.Show("TÉNYLEG NE", "Kérlek ne nyomj az igenre", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            int Összeg = 0;

           

            foreach (var item in infók)
            {
                if(item.Oldalszam > OLdalak)
                {
                    OLdalak = item.Oldalszam;
                    kiadas = item.KiadasEve;
                }

                if (item.KiadasEve > 2000)
                {
                    szamlalo ++;
                    Összeg += item.Oldalszam;
                }

                
            }

            int Vegsõösszeg = Összeg / szamlalo;

            MessageBox.Show($"A leghosszabb könyv {kiadas}-ban lett kiadva. A 2000-utáni könyvek átlagosan {Vegsõösszeg} oldal hosszúak");
        }
    }
}