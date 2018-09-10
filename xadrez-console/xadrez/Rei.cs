﻿using System;
using tabuleiro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        { }

        public override string ToString()
        {
            return "R";
        }
    }
}
