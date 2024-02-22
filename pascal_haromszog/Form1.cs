namespace pascal_haromszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Faktorialis(int n)
        {
            if (n == 0) return 1;
            return n * Faktorialis(n - 1);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
                for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Button b = new Button();
                    Controls.Add(b);
                    b.Top = sor * m;
                    b.Left = oszlop * m;
                    b.Height = m;
                    b.Width = m;
                    int x = Faktorialis(sor) / (Faktorialis(oszlop))* Faktorialis(sor-oszlop);
                    b.Text = x.ToString();
                }
            }
        }
    }
}