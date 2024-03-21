namespace snake
{
    public partial class Form1 : Form
    {
        int fejX;
        int fejY;
        int ir�ny_x;
        int ir�ny_y;
        int L�p�sSz�m;
        List<Kigy�Elem> k�gy� = new List<Kigy�Elem>();
        public Form1()
        {
            InitializeComponent();

            fejX = 100;
            fejY = 100;
            ir�ny_x = 1;
            ir�ny_y = 0;
            L�p�sSz�m = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            L�p�sSz�m++;

            if (L�p�sSz�m % 5 == 0)
            {
                Kaja kaja = new Kaja();
                kaja.Top = L�p�sSz�m * 20;
                kaja.Left = L�p�sSz�m * 20;
                

                Controls.Add(kaja);
            }

            foreach (object item in Controls)
            {
                if (item is Kaja)
                {
                    Kaja k = (Kaja)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        Kigy�Elem.hossz++;
                    }
                }
            }

            //Fejn�veszt�s
            fejX += ir�ny_x * Kigy�Elem.M�ret;
            fejY += ir�ny_y * Kigy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is Kigy�Elem)
                {
                    Kigy�Elem k = (Kigy�Elem)item;

                    if (k.Top == fejY && k.Left == fejX)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            if (Controls.Count > Kigy�Elem.hossz)
            {
                Kigy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }



            Kigy�Elem ke = new Kigy�Elem();
            ke.Top = fejY;
            ke.Left = fejX;
            k�gy�.Add(ke);
            Controls.Add(ke);
            if (L�p�sSz�m % 2 == 0) ke.BackColor = Color.Yellow;


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}