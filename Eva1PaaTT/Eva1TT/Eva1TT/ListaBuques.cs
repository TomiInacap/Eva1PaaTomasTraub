/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva1TT
{
    internal class ListaBuques
    {
        public ListaBuques()
        {
        }

        
    
        
        public bool AgregarB(Buque nuevo)
        {
            bool res = false;
            int pos = Okarey();
            if (pos > -1)
            {
                losBuques[pos] = nuevo;
                res = true;
            }
            return res;
        }

        private int Okarey()
        {
            int b = -1;
            for (int i = 0; i < losBuques.Length; i++)
            {
                if (losBuques[i] == null)
                {
                    b = i;
                    break;
                }
            }
            return b;
        }


        public Buque BuscarBuque(string codigo)
        {
            Buque buscado = null;
            foreach (Buque bm in losBuques)
            {
                if (bm != null)
                {
                    if (bm.Codigo == codigo)
                    {
                        buscado = bm;
                        break;
                    }
                }
            }
            return buscado;
        }

    }
}

*/