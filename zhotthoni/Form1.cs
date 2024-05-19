using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace zhotthoni
{
    public partial class Form1 : Form
    {
        BindingList<kerdesek> kerdeseke = new BindingList<kerdesek>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<kerdesek>();

                foreach (var item in tömb)
                {
                    kerdeseke.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            kerdesekBindingSource.DataSource = kerdeseke;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(kerdeseke);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kerdesekBindingSource.Current == null) return;

            if (MessageBox.Show("Kérlek ne", "tényleg", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kerdesekBindingSource.RemoveCurrent();
            }
        }

        private void uj_Click(object sender, EventArgs e)
        {
            if (kerdesekBindingSource.Current == null) return;

            UjSor ujSor = new UjSor();

            ujSor.ujkerdes = kerdesekBindingSource.Current as kerdesek;

            ujSor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {

                
                int helyesValaszCount = 0;
                int helyesValaszCount2 = 0;
                int helyesValaszCount3 = 0;



                foreach (var item in kerdeseke)
                {

                    if (item.HelyesValasz == 1)
                    {
                        helyesValaszCount++;


                    }
                    if (item.HelyesValasz == 2)
                    {
                        helyesValaszCount2++;


                    }
                    if (item.HelyesValasz == 3)
                    {
                        helyesValaszCount3++;

                    }
                }

                
                List<int> numbers = new List<int> { helyesValaszCount, helyesValaszCount2, helyesValaszCount3 };
                
                
                int maxFromList = numbers.Max();

                MessageBox.Show("HelyesVálasz count: " + maxFromList.ToString());




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)


        {
            if (kerdesekBindingSource.Current == null) return;

            UjSor ujSor = new UjSor();

            ujSor.ujkerdes = kerdesekBindingSource.AddNew() as kerdesek;

            ujSor.Show();
        }
    }
}
