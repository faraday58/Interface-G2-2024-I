﻿using System;

namespace Interface_G2_2024_I
{
    internal abstract class LineaBlanca
    {
        private string marca;

        public string Marca { get => marca;
            set => marca = value == "" ? "Genérica" : value  ;
        
        }

    }
}
