using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadik
{
    internal class SzamoloGomb : VillogoGomb
    {
        int szám = 1;

        public SzamoloGomb()
        {
            Height = 20;
            Width = 20;

            Text = szám.ToString();
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {

            if (szám < 6)
            {
                Text = szám++.ToString();
            }
            else
            {
                szám = 1;
                Text = szám.ToString();
            }

        }
    }
}
