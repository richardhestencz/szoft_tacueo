using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhotthoni
{
    public partial class UjSor : Form
    {
        public kerdesek ujkerdes = new kerdesek();
        public UjSor()
        {
            InitializeComponent();
        }

        private void UjSor_Load(object sender, EventArgs e)
        {

            kerdesekBindingSource.DataSource = ujkerdes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
