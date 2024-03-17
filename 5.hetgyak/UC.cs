using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.hetgyak
{
    public partial class UC : UserControl
    {
        public int alma;
        

        public UC()
        {
            InitializeComponent();
            int dovalasz = alma;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Load(object sender, EventArgs e)
        {
            
        }


        int kattintas;
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            Szinezesem();
            kattintas = 1;
           
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            Szinezesem();
            kattintas = 3;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red; 
            Szinezesem();
            kattintas = 2;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            Szinezesem();
            kattintas = 4;
            
        }

        void Szinezesem()
        {

            if (alma == 1) button1.BackColor = Color.Green;
            if (alma == 2) button2.BackColor = Color.Green;
            if (alma == 3) button3.BackColor = Color.Green;
            if (alma == 4) button4.BackColor = Color.Green;
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
    }
    
}
