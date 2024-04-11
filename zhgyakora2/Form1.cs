using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace zhgyakora2
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countrylist = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            countryDataBindingSource.DataSource = countrylist;


            StreamReader sr = new StreamReader("varosok.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countrylist.Add(item);
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                countryDataBindingSource.RemoveCurrent();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fce = new Form2();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.Show();
        }
    }
}