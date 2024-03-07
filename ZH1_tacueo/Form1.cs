namespace ZH1_tacueo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Faktorialis(int n)
            {
                if (n == 0) return 1;
                return n * Faktorialis(n - 1);
            }



            List<Sor> lista = new List<Sor>();
            for (int i = 1; i < 11; i++)
            {
                Sor sor = new Sor();
                sor.Szám = i;
                sor.Faktoriális = Faktorialis(i);

                lista.Add(sor);
            }
            dataGridView1.DataSource = lista;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 13; sor++)
            {
                for (int oszlop = 0; oszlop < 13; oszlop++)
                {
                    SensitiveButton gomb = new SensitiveButton();
                    Controls.Add(gomb);
                    gomb.Left = oszlop * 40;
                    gomb.Top = sor * 40;
                    
                }
            }
        }
    }

}