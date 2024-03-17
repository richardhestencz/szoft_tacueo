namespace _5.hetgyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0;

            StreamReader sr = new StreamReader("jatek2.txt");


            int szamlalo = 0;
            while (!sr.EndOfStream && x < 100)
            {
                string kerdes = sr.ReadLine();
                string valasz1 = sr.ReadLine();
                string valasz2= sr.ReadLine();
                string valasz3 = sr.ReadLine();
                string valasz4 = sr.ReadLine();
                int JóVálasz = int.Parse(sr.ReadLine());

                UC uc = new UC();

                uc.Top = (uc.Height + 1) * x;

                uc.label1.Text = kerdes;

                uc.button1.Text = valasz1;
                uc.button2.Text = valasz2;
                uc.button3.Text = valasz3;
                uc.button4.Text = valasz4;

                uc.alma = JóVálasz;
                szamlalo++;
                uc.textBox1.Text = szamlalo.ToString();

                Controls.Add(uc);

                x++;
            }

            sr.Close();
        }
    }
}
