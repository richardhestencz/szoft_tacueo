﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class KigyóElem : PictureBox
    {
        public static int Méret = 20;
        public static int hossz = 1;

        public KigyóElem()
        {
            Width = KigyóElem.Méret;
            Height = KigyóElem.Méret;
            BackColor = Color.Fuchsia;
        }
    }
}
