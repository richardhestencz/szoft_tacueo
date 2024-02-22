namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 1; sor < 11; sor++)
            {
                for (int oszlop = 1; oszlop < 11; oszlop++)
                {
                    Button button = new Button();
                    button.Text = (sor * oszlop).ToString();
                    button.Top = sor * 40;
                    button.Left = oszlop * 40;
                    button.Height = 40;
                    button.Width = 40;
                    Controls.Add(button);                                                                                       
                }
            }
        }
    }
}