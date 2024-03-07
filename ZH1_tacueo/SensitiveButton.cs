using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_tacueo
{
    internal class SensitiveButton : Button
    {
        int szám;
        public SensitiveButton()
        {
            Width = 40;
            Height = 40;
            MouseEnter += SensitiveButton_MouseEnter;
            szám = 1;
            Text = szám.ToString();
        }

        private void SensitiveButton_MouseEnter(object? sender, EventArgs e)
        {
            if(szám < 10)
            {
                szám++;
                Text = szám.ToString();
            }
            
        }
    }
}
