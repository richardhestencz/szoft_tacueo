namespace snake
{
    public partial class Form1 : Form
    {
        int fejX;
        int fejY;
        int irány_x;
        int irány_y;
        int LépésSzám;
        List<KigyóElem> kígyó = new List<KigyóElem>();
        public Form1()
        {
            InitializeComponent();

            fejX = 100;
            fejY = 100;
            irány_x = 1;
            irány_y = 0;
            LépésSzám = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            LépésSzám++;

            if (LépésSzám % 5 == 0)
            {
                Kaja kaja = new Kaja();
                kaja.Top = LépésSzám * 20;
                kaja.Left = LépésSzám * 20;
                

                Controls.Add(kaja);
            }

            foreach (object item in Controls)
            {
                if (item is Kaja)
                {
                    Kaja k = (Kaja)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        KigyóElem.hossz++;
                    }
                }
            }

            //Fejnövesztés
            fejX += irány_x * KigyóElem.Méret;
            fejY += irány_y * KigyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KigyóElem)
                {
                    KigyóElem k = (KigyóElem)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            if (Controls.Count > KigyóElem.hossz)
            {
                KigyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }



            KigyóElem ke = new KigyóElem();
            ke.Top = fejY;
            ke.Left = fejX;
            kígyó.Add(ke);
            Controls.Add(ke);
            if (LépésSzám % 2 == 0) ke.BackColor = Color.Yellow;


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}