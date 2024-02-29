using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace harmadik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            Controls.Add(b);
            int magasság = ;
            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    SzamoloGomb p = new SzamoloGomb();
                    Controls.Add(p);
                    p.Height = méret;
                    p.Width = méret;
                    p.Left = méret * oszlop;
                    p.Top = méret * sor;
                }
            }
    }
}
