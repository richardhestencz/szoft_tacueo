namespace harmadik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            Controls.Add(b);
            b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;
                
            int m�ret = 20;
            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    SzamoloGomb p = new SzamoloGomb();
                    Controls.Add(p);
                    p.Height = m�ret;
                    p.Width = m�ret;
                    p.Left = m�ret * oszlop;
                    p.Top = m�ret * sor;
                }
            }

        }
    }
}