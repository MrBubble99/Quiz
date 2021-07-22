using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜbungenDieVierte
{
    class NumeroRaro
    {
        public static int CadenaMulti(int num)
        {
            int inicio = 1;
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {

                sum = inicio * i;
                inicio = sum;

            }
            return sum;
        }
    }
}

