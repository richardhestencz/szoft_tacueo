using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_tacueo
{
    public partial class HozzaAdas : Form
    {
        public Infok UjInfok = new Infok();
        public HozzaAdas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HozzaAdas_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = UjInfok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
