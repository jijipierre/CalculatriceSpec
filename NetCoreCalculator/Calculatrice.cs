using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreCalculator
{
    public class Calculatrice
    {
        public int m_PremierNumero;
        public int m_DexiemeNumero;

        public int PremierNumero { get => m_PremierNumero; set => m_PremierNumero = value; }
        public int DexiemeNumero { get => m_DexiemeNumero; set => m_DexiemeNumero = value; }

        public int Add()
        {
            return PremierNumero + DexiemeNumero;
        }
        public int Soustraction()
        {
            return PremierNumero - DexiemeNumero;
        }
        public int Division()
        {
            int resultat = 0;
            if (DexiemeNumero != 0)
            {
                resultat = PremierNumero / DexiemeNumero;
            }
            return resultat;
        }
        public int Multipier()
        {
            return PremierNumero * DexiemeNumero;
        }
    }
}
